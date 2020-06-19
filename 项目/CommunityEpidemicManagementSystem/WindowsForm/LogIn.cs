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
    public partial class LogIn : Form
    {
        public User user { get; set; }
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string UserId = txtId.Text;
            string Pwd = txtPassword.Text;
            if(UserId == "")
            {
                MessageBox.Show("请输入用户名！");
                txtPassword.Text = "";
                txtId.Text = "";
                return;
            }
            if (UserService.Get(UserId) == null)
            {
                MessageBox.Show("用户不存在！");
                txtPassword.Text = "";
                txtId.Text = "";
                return;
            }
            ResidentsMainForm residents = null;
            WorkerMainForm worker = null;
            AdministratorMainForm administrator = null;
            this.user = UserService.Get(UserId);
            if (user.Password == Pwd)
            {
                this.Hide();
                if (user.UserType == UserType.Resident) // 居民
                {
                    residents = new ResidentsMainForm(user);
                    residents.ShowDialog(this);
                }
                else if (user.UserType == UserType.Worker) // 工作人员
                {
                    worker = new WorkerMainForm(user);
                    worker.ShowDialog(this);
                }
                else if (user.UserType == UserType.Administrator) // 管理员
                {
                    administrator = new AdministratorMainForm(user);
                    administrator.ShowDialog(this);
                }
            }
            else
            {
                MessageBox.Show("用户名或密码错误，请从新输入！");
            }
            txtPassword.Text = "";
            this.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register(new User());
            this.Hide();
            if(register.ShowDialog() == DialogResult.OK)
            {
                register.CurrentUser.UserType = UserType.Resident;
                UserService.Add(register.CurrentUser);
            }
            txtId.Text = "";
            txtPassword.Text = "";
            this.Show();
        }
    }
}
