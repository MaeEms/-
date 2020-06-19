using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunityEpidemicManagementSystem
{
    public partial class AdministratorMainForm : Form
    {
        public User user { get; set; }
        public AdministratorMainForm()
        {
            InitializeComponent();
        }

        public AdministratorMainForm(User user) : this()
        {
            this.user = user;

        }

        // 关闭窗口
        private void CloseForm()
        {
            //palParent为panel控件
            foreach (Control item in this.pnlParent.Controls)
            {
                if (item is Form)
                {
                    Form form = (Form)item;
                    form.Close();
                    this.pnlParent.Controls.Remove(form);
                }
            }
        }

        //打开窗口
        private void OpenForm(Form frm)
        {
            frm.TopLevel = false;//取消非顶级窗体
            frm.WindowState = FormWindowState.Maximized;//将窗体最大化
            frm.FormBorderStyle = FormBorderStyle.None;//设为无边框
            frm.Parent = this.pnlParent;//指定该窗体的父窗体
            frm.Show();//展示窗体
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            InformationAdministrator information = new InformationAdministrator();
            CloseForm();
            OpenForm(information);
        }

        private void btnMission_Click(object sender, EventArgs e)
        {
            Mission mission = new Mission();
            CloseForm();
            OpenForm(mission);
        }

        private void btnPunchInRecord_Click(object sender, EventArgs e)
        {
            HealthInfoAdministrator healthInfo = new HealthInfoAdministrator();
            CloseForm();
            OpenForm(healthInfo);
        }

        private void btnTravelExp_Click(object sender, EventArgs e)
        {
            TravelExperience travelExperience = new TravelExperience();
            CloseForm();
            OpenForm(travelExperience);
        }

        private void btnAccessMng_Click(object sender, EventArgs e)
        {
            AccessManagement accessManagement = new AccessManagement();
            CloseForm();
            OpenForm(accessManagement);
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            AdministratorTaskForm administratorTask = new AdministratorTaskForm();
            CloseForm();
            OpenForm(administratorTask);
        }

        private void btnEmergency_Click(object sender, EventArgs e)
        {
            EmergencyForm emergency = new EmergencyForm();
            CloseForm();
            OpenForm(emergency);
        }
    }
}
