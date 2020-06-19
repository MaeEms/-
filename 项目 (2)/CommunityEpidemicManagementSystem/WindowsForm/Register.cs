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
    public partial class Register : Form
    {
        public User CurrentUser { get; set; }
        public Register()
        {
            InitializeComponent();
        }

        public Register(User user) : this()
        {
            CurrentUser = user;
            UserBindingSource.DataSource = CurrentUser;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InformationEdit information = new InformationEdit(new Resident());
            try
            {
                if(information.ShowDialog() == DialogResult.OK)
                {
                    information.Resident.ResidentId = txtUserId.Text;
                    ResidentService.Add(information.Resident);
                    ResidentBindingSource.ResetBindings(false);
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Resident resident = ResidentBindingSource.Current as Resident;
            if (resident == null)
            {
                MessageBox.Show("请选择一个家庭成员进行修改");
                return;
            }
            InformationEdit information = new InformationEdit(resident);
            if(information.ShowDialog() == DialogResult.OK)
            {
                ResidentBindingSource.ResetBindings(false);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Resident resident = UserBindingSource.Current as Resident;
            if (resident == null)
            {
                MessageBox.Show("请选择一个家庭成员进行删除");
                return;
            }
            DialogResult MsgBoxResult;
            MsgBoxResult = MessageBox.Show("您确定要删除吗？", "提示", MessageBoxButtons.YesNo);
            if(MsgBoxResult == DialogResult.Yes)
            {
                ResidentService.Remove(resident.ResidentId);
                UserBindingSource.ResetBindings(false);
            }
        }
    }
}