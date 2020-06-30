using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CommunityEpidemicManagementSystem
{
    public partial class Mission : Form
    {
        public User CurrentUser { get; set; }
        public Mission()
        {
            InitializeComponent();
        }


        public void UserTypeJudge(User user, List<ResidentMission> missions, List<ResidentMission> historyMissions)
        {
            UserType identity = CurrentUser.UserType;
            if (identity == UserType.Resident)
            {
                btnAllocate.Visible = false;
                btnFinish.Visible = false;
                btnRefuse.Visible = false;
                missions = ResidentMissionService.QueryByStatusAndId(CurrentUser.UserId, MissionStatus.未接受);
                missions = missions.Union(ResidentMissionService.QueryByStatusAndId(CurrentUser.UserId, MissionStatus.已接受)).ToList();
                historyMissions = ResidentMissionService.QueryByStatusAndId(CurrentUser.UserId, MissionStatus.已完成);
                historyMissions = historyMissions.Union(ResidentMissionService.QueryByStatusAndId(CurrentUser.UserId, MissionStatus.拒绝)).ToList();
            }
            else if (identity == UserType.Worker)
            {
                btnCreate.Visible = false;
                btnEdit.Visible = false;
                btnCancel.Visible = false;
                btnAllocate.Visible = false;
                string worker = WorkerService.QueryByUser(CurrentUser.UserId)[0].Name;
                missions = ResidentMissionService.QueryByStatusAndId(worker, MissionStatus.已接受);
                historyMissions = ResidentMissionService.QueryByStatusAndId(worker, MissionStatus.已完成);
                historyMissions = historyMissions.Union(ResidentMissionService.QueryByStatusAndId(worker, MissionStatus.拒绝)).ToList();
            }
            else if(identity == UserType.Administrator)
            {
                btnCreate.Visible = false;
                btnEdit.Visible = false;
                btnCancel.Visible = false;
                btnFinish.Visible = false;
                missions = ResidentMissionService.QueryByStatus(MissionStatus.未接受);
                historyMissions = ResidentMissionService.QueryByStatus(MissionStatus.已接受);
                historyMissions = ResidentMissionService.QueryByStatus(MissionStatus.已完成);
                historyMissions = historyMissions.Union(ResidentMissionService.QueryByStatus(MissionStatus.拒绝)).ToList();
            }
        }

        public Mission(User user) : this()
        {
            CurrentUser = user;
            List<ResidentMission> missions = new List<ResidentMission>();
            List<ResidentMission> historyMissions = new List<ResidentMission>();
            UserTypeJudge(CurrentUser, missions, historyMissions);
            MissionBindingSource.DataSource = missions;
            MissionHisBindingSource.DataSource = historyMissions;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            UserType identity = CurrentUser.UserType;
            List<ResidentMission> missions = new List<ResidentMission>();
            List<ResidentMission> historyMissions = new List<ResidentMission>();
            if (identity == UserType.Resident)
            {
                cmbQueryW.Visible = false;
                switch (cmbQueryU.SelectedIndex)
                {
                    case 0: // 全部
                        UserTypeJudge(CurrentUser, missions, historyMissions);
                        MissionBindingSource.DataSource = missions;
                        break;
                    case 1: // 根据日期查询
                        DateTime dt = Convert.ToDateTime(txtQuery.Text);
                        UserTypeJudge(CurrentUser, missions, historyMissions);
                        List<ResidentMission> temp = new List<ResidentMission>();
                        var list = from ResidentMission s in missions
                                   where s.CreatedTime == dt
                                   select s;
                        temp = list.ToList();
                        MissionBindingSource.DataSource = temp;
                        break;
                }
            }
            else
            {
                cmbQueryU.Visible = false;
                switch (cmbQueryW.SelectedIndex)
                {
                    case 0: // 全部
                        UserTypeJudge(CurrentUser, missions, historyMissions);
                        MissionBindingSource.DataSource = missions;
                        break;
                    case 1: // 根据编号查询
                        UserTypeJudge(CurrentUser, missions, historyMissions);
                        List<ResidentMission> temp = new List<ResidentMission>();
                        var list = from ResidentMission s in missions
                                   where s.ResidentMissionId == txtQuery.Text
                                   select s;
                        temp = list.ToList();
                        MissionBindingSource.DataSource = temp;
                        break;
                    case 2: // 根据用户ID查询
                        UserTypeJudge(CurrentUser, missions, historyMissions);
                        var id = from ResidentMission s in missions
                                   where s.Resident.User.UserId == txtQuery.Text
                                   select s;
                        temp = id.ToList();
                        MissionBindingSource.DataSource = ResidentMissionService.QueryByUserId(txtQuery.Text);
                        break;
                    case 3: // 根据日期查询
                        DateTime dt = Convert.ToDateTime(txtQuery.Text);
                        UserTypeJudge(CurrentUser, missions, historyMissions);
                        var date = from ResidentMission s in missions
                                 where s.CreatedTime == dt
                                 select s;
                        temp = date.ToList();
                        MissionBindingSource.DataSource = ResidentMissionService.QuerydByDate(dt);
                        break;
                }
            }
            MissionBindingSource.ResetBindings(true);
        }

        // Residents
        private void btnCreate_Click(object sender, EventArgs e)
        {
            MissionAddResident addResident = new MissionAddResident(new ResidentMission());
            if (addResident.ShowDialog() == DialogResult.OK)
            {
                addResident.Mission.CreatedTime = DateTime.Now;
                addResident.Mission.Resident = ResidentService.Get(CurrentUser.UserId);
                addResident.Mission.State = MissionStatus.未接受;
                ResidentMissionService.Add(addResident.Mission);
                QueryAll(CurrentUser);
            }
        }

        // Residents
        private void btnEdit_Click(object sender, EventArgs e)
        {
            ResidentMission mission = MissionBindingSource.Current as ResidentMission;
            if(mission == null)
            {
                MessageBox.Show("请选择一个需求进行修改");
                return;
            }
            if(mission.State == MissionStatus.已接受)
            {
                MessageBox.Show("订单已接受，无法修改！如有特殊情况请联系管理员。");
                return;
            }
            mission = ResidentMissionService.Get(mission.ResidentMissionId);
            MissionAddResident addResident = new MissionAddResident(mission);
            if(addResident.ShowDialog() == DialogResult.OK)
            {
                ResidentMissionService.Update(addResident.Mission);
                QueryAll(CurrentUser);
            }
        }

        // Residents
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResidentMission mission = MissionBindingSource.Current as ResidentMission;
            if (mission == null)
            {
                MessageBox.Show("请选择一个需求进行取消");
                return;
            }
            if (mission.State == MissionStatus.已接受)
            {
                MessageBox.Show("订单已接受，无法取消！如有特殊情况请联系管理员。");
                return;
            }
            ResidentMissionService.Remove(mission.ResidentMissionId);
            QueryAll(CurrentUser);
        }

        // Worker
        private void btnFinish_Click(object sender, EventArgs e)
        {
            ResidentMission mission = MissionBindingSource.Current as ResidentMission;
            if (mission == null)
            {
                MessageBox.Show("请选择一个需求");
                return;
            }
            mission.State = MissionStatus.已完成;
            mission.FinishedTime = DateTime.Now;
            QueryAll(CurrentUser);
        }

        // Worker & Administrator
        private void btnRefuse_Click(object sender, EventArgs e)
        {
            ResidentMission mission = MissionBindingSource.Current as ResidentMission;
            if (mission == null)
            {
                MessageBox.Show("请选择一个需求进行拒绝");
                return;
            }
            mission.State = MissionStatus.拒绝;
            QueryAll(CurrentUser);
        }

        // Administrator
        private void btnAllocate_Click(object sender, EventArgs e)
        {
            ResidentMission mission = MissionBindingSource.Current as ResidentMission;
            if (mission == null)
            {
                MessageBox.Show("请选择一个需求进行分配");
                return;
            }
            mission = ResidentMissionService.Get(mission.ResidentMissionId);
            MissionAllocate allocate = new MissionAllocate(mission);
            if (allocate.ShowDialog() == DialogResult.OK)
            {
                allocate.Mission.State = MissionStatus.已接受;
                ResidentMissionService.Update(allocate.Mission);
                QueryAll(CurrentUser);
            }
        }

        private void QueryAll(User user)
        {
            UserType identity = CurrentUser.UserType;
            List<ResidentMission> missions = new List<ResidentMission>();
            List<ResidentMission> historyMissions = new List<ResidentMission>();
            UserTypeJudge(CurrentUser, missions, historyMissions);
            if (identity == UserType.Resident)
            {
                MissionBindingSource.DataSource = missions;
            }
            else if (identity == UserType.Worker)
            {
                MissionBindingSource.DataSource = missions;
            }
            else
            {
                MissionBindingSource.DataSource = missions;
            }
            MissionBindingSource.ResetBindings(false);
        }

        private void dgvMissionList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ResidentMission mission = MissionBindingSource.Current as ResidentMission;
            MissionList missionList = new MissionList(mission);
            missionList.ShowDialog();
        }

        private void btnQueryHistory_Click(object sender, EventArgs e)
        {
            UserType identity = CurrentUser.UserType;
            List<ResidentMission> missions = new List<ResidentMission>();
            List<ResidentMission> historyMissions = new List<ResidentMission>();
            switch (cmbQueryW.SelectedIndex)
            {
                case 0: // 全部
                    UserTypeJudge(CurrentUser, missions, historyMissions);
                    MissionBindingSource.DataSource = historyMissions;
                    break;
                case 1: // 根据编号查询
                    UserTypeJudge(CurrentUser, missions, historyMissions);
                    List<ResidentMission> temp = new List<ResidentMission>();
                    var list = from ResidentMission s in historyMissions
                               where s.ResidentMissionId == txtQuery.Text
                               select s;
                    temp = list.ToList();
                    MissionBindingSource.DataSource = temp;
                    break;
                case 2: // 根据用户ID查询
                    UserTypeJudge(CurrentUser, missions, historyMissions);
                    var id = from ResidentMission s in historyMissions
                             where s.Resident.User.UserId == txtQuery.Text
                             select s;
                    temp = id.ToList();
                    MissionBindingSource.DataSource = ResidentMissionService.QueryByUserId(txtQuery.Text);
                    break;
                case 3: // 根据日期查询
                    DateTime dt = Convert.ToDateTime(txtQuery.Text);
                    UserTypeJudge(CurrentUser, missions, historyMissions);
                    var date = from ResidentMission s in historyMissions
                               where s.CreatedTime == dt
                               select s;
                    temp = date.ToList();
                    MissionBindingSource.DataSource = ResidentMissionService.QuerydByDate(dt);
                    break;
            }
            MissionBindingSource.ResetBindings(true);
        }
    }
}
