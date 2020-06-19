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
    public partial class TravelExperience : Form
    {
        public User CurrentUser { get; set; }
        public TravelExperience()
        {
            InitializeComponent();
        }

        public TravelExperience(User user) : this()
        {
            CurrentUser = user;
            // 判断权限
            UserType identity = CurrentUser.UserType;
            if(identity == UserType.Resident) 
            {
                groupBox3.Visible = false;
                TravelBindingSource.DataSource = TravelRecordService.QueryByUserID(CurrentUser.UserId);
            }
            else if(identity == UserType.Administrator)
            {
                btnAdd.Visible = false;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
                TravelBindingSource.DataSource = TravelRecordService.GetAll();
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            UserType identity = CurrentUser.UserType;
            switch (cmbQuery.SelectedIndex)
            {
                case 0: // 全部
                    if(identity == UserType.Resident)
                    {
                        TravelBindingSource.DataSource = TravelRecordService.QueryByUserID(CurrentUser.UserId);
                    }
                    else if (identity == UserType.Administrator)
                    {
                        TravelBindingSource.DataSource = TravelRecordService.GetAll();
                    }
                    break;
                case 1: // 根据ID查询
                    TravelBindingSource.DataSource = TravelRecordService.QueryByResidentID(txtQuery.Text);
                    break;
                case 2: // 根据日期查询
                    DateTime dt = Convert.ToDateTime(txtQuery.Text);
                    TravelBindingSource.DataSource = TravelRecordService.QuerydByDateLeave(dt);
                    break;
            }
            TravelBindingSource.ResetBindings(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TravelExperienceEdit experienceEdit = new TravelExperienceEdit(new TravelRecord());
            if(experienceEdit.ShowDialog() == DialogResult.OK)
            {
                experienceEdit.record.User = CurrentUser;
                TravelRecordService.Add(experienceEdit.record);
                QueryAll(CurrentUser);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TravelRecord record = TravelBindingSource.Current as TravelRecord;
            if (record == null)
            {
                MessageBox.Show("请选择一个记录进行修改");
                return;
            }
            TravelExperienceEdit experienceEdit = new TravelExperienceEdit(record);
            if (experienceEdit.ShowDialog() == DialogResult.OK)
            {
                TravelRecordService.Update(experienceEdit.record);
                QueryAll(CurrentUser);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TravelRecord record = TravelBindingSource.Current as TravelRecord;
            if(record == null)
            {
                MessageBox.Show("请选择一个记录进行删除");
                return;
            }
            TravelRecordService.Remove(record.TravelRecordId);
            QueryAll(CurrentUser);
        }

        private void QueryAll(User user)
        {
            TravelBindingSource.DataSource = ResidentMissionService.QueryByUserId(user.UserId);
            TravelBindingSource.ResetBindings(false);
        }
    }
}
