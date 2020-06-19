using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunityEpidemicManagementSystem
{
    public partial class EmergencyForm : Form
    {
        public User CurrentUser { get; set; }
        public EmergencyForm()
        {
            InitializeComponent();
        }

        public void UserTypeJudge(User user, List<Emergency> emergency, List<Emergency> historyEmergency)
        {
            UserType identity = CurrentUser.UserType;
            if (identity == UserType.Resident)
            {
                btnAllocate.Visible = false;
                btnAccept.Visible = false;
                btnFinish.Visible = false;
                emergency = EmergencyService.QueryByIdAndStatus(CurrentUser.UserId, EmergencyStatus.未处理);
                emergency = emergency.Union(EmergencyService.QueryByIdAndStatus(CurrentUser.UserId, EmergencyStatus.处理中)).ToList();
                historyEmergency = EmergencyService.QueryByIdAndStatus(CurrentUser.UserId, EmergencyStatus.已完成);
            }
            else if (identity == UserType.Worker)
            {
                btnCreate.Visible = false;
                btnAllocate.Visible = false;
                string worker = WorkerService.QueryByUser(CurrentUser.UserId)[0].WorkerId;
                emergency = EmergencyService.QueryByIdAndStatus(worker, EmergencyStatus.未处理);
                emergency = emergency.Union(EmergencyService.QueryByIdAndStatus(worker, EmergencyStatus.处理中)).ToList();
                historyEmergency = EmergencyService.QueryByIdAndStatus(worker, EmergencyStatus.已完成);
            }
            else
            {
                btnCreate.Visible = false;
                btnAccept.Visible = false;
                btnFinish.Visible = false;
                emergency = EmergencyService.QueryByStatus(EmergencyStatus.未处理);
                emergency = emergency.Union(EmergencyService.QueryByStatus(EmergencyStatus.处理中)).ToList();
                historyEmergency = EmergencyService.QueryByStatus(EmergencyStatus.已完成);
            }
        }

        public EmergencyForm(User user) : this()
        {
            CurrentUser = user;
            List<Emergency> emergencies = new List<Emergency>();
            List<Emergency> historyEmergencies = new List<Emergency>();
            UserTypeJudge(CurrentUser, emergencies, historyEmergencies);
            EmergencyBindingSource.DataSource = emergencies;
            EmergencyHisBindingSource.DataSource = historyEmergencies;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Emergency emergency = EmergencyBindingSource.Current as Emergency;
            if (emergency == null)
            {
                MessageBox.Show("请选择一个事件");
                return;
            }
            emergency.WorkerId = WorkerService.QueryByUser(CurrentUser.UserId)[0].WorkerId;
            emergency.EmergState = EmergencyStatus.处理中;
            QueryAll(CurrentUser);
        }

        private void btnAllocate_Click(object sender, EventArgs e)
        {
            Emergency emergency = EmergencyBindingSource.Current as Emergency;
            if (emergency == null)
            {
                MessageBox.Show("请选择一个需求进行分配");
                return;
            }
            emergency = EmergencyService.Get(emergency.EmergencyId);
            EmergencyAllocate allocate = new EmergencyAllocate(emergency);
            if (allocate.ShowDialog() == DialogResult.OK)
            {
                EmergencyService.Update(allocate.emergency);
                QueryAll(CurrentUser);
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Emergency emergency = EmergencyBindingSource.Current as Emergency;
            if (emergency == null)
            {
                MessageBox.Show("请选择一个事件");
                return;
            }
            emergency.EmergState = EmergencyStatus.已完成;
            QueryAll(CurrentUser);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            EmergencyAddResident addResident = new EmergencyAddResident(new Emergency());
            if (addResident.ShowDialog() == DialogResult.OK)
            {
                addResident.emergency.RaiseTime = DateTime.Now;
                addResident.emergency.resident = ResidentService.Get(CurrentUser.UserId);
                addResident.emergency.EmergState = EmergencyStatus.未处理;
                EmergencyService.Add(addResident.emergency);
                QueryAll(CurrentUser);
            }
        }

        private void QueryAll(User user)
        {
            UserType identity = CurrentUser.UserType;
            List<Emergency> emergencies = new List<Emergency>();
            List<Emergency> historyEmergencies = new List<Emergency>();
            UserTypeJudge(CurrentUser, emergencies, historyEmergencies);
            if (identity == UserType.Resident)
            {
                EmergencyBindingSource.DataSource = emergencies;
            }
            else if (identity == UserType.Worker)
            {
                EmergencyBindingSource.DataSource = emergencies;
            }
            else
            {
                EmergencyBindingSource.DataSource = emergencies;
            }
            EmergencyBindingSource.ResetBindings(false);
        }
    }
}
