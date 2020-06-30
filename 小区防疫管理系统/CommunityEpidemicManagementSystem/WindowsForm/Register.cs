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
        int count = 0;
        public User CurrentUser { get; set; }
        public UserType userType = UserType.Resident;
        public Register()
        {
            InitializeComponent();
        }
        public Register(User user) : this()
        {
            this.CurrentUser = user;
            this.UserBindingSource.DataSource = user;
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            InformationEdit information = new InformationEdit(new Resident());
            //try
            //{
                if(information.ShowDialog() == DialogResult.OK)
                {
                    //information.Resident.ResidentId = C.Text;
                    information.Resident.CardId(information.Resident.IdCard);
                    information.Resident.UserId = CurrentUser.UserId;
                    if (count++ == 0)
                    information.Resident.User = CurrentUser; 
                    ResidentService.Add(information.Resident);
                    ResidentBindingSource.DataSource = ResidentService.QueryByUser(CurrentUser.UserId);
                    ResidentBindingSource.ResetBindings(false);
                }
           //}
            //catch (Exception e2)
            //{
                //MessageBox.Show(e2.Message);
            //}
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Resident resident = ResidentBindingSource.Current as Resident;
            if (resident == null)
            {
                MessageBox.Show("请选择一个家庭成员进行修改");
                return;
            }
            resident = ResidentService.Get(resident.ResidentId);
            InformationEdit information = new InformationEdit(resident);
            if(information.ShowDialog() == DialogResult.OK)
            {
                information.Resident.CardId(information.Resident.IdCard);
                ResidentService.Update(information.Resident);
                ResidentBindingSource.DataSource = ResidentService.QueryByUser(CurrentUser.UserId);
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
            resident = ResidentService.Get(resident.ResidentId);
            DialogResult MsgBoxResult;
            MsgBoxResult = MessageBox.Show("您确定要删除吗？", "提示", MessageBoxButtons.YesNo);
            if(MsgBoxResult == DialogResult.Yes)
            {
                ResidentService.Remove(resident.ResidentId);
                ResidentBindingSource.DataSource = ResidentService.QueryByUser(CurrentUser.UserId);
                UserBindingSource.ResetBindings(false);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string password = txtPswd.Text;
            string ensurepassword = txtPswdensuer.Text;
            if (UserTypeComboBox.SelectedIndex == 0)
                CurrentUser.UserType = UserType.Resident;
            else if (UserTypeComboBox.SelectedIndex == 1)
                CurrentUser.UserType = UserType.Worker;
            else
                CurrentUser.UserType = UserType.Administrator;
            if (password == ensurepassword) {
                MessageBox.Show("注册成功！您的账号是:" + CurrentUser.UserId + ",密码是:" + CurrentUser.Password);
                return;
            }
            else
            {
                MessageBox.Show("两次输入的密码不一致，请重新尝试");
                txtPswdensuer.Text = "";
            }
        }
    }
}