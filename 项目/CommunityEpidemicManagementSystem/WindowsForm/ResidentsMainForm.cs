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
    public partial class ResidentsMainForm : Form
    {
        public User user { get; set; }
        public ResidentsMainForm()
        {
            InitializeComponent();
        }

        public ResidentsMainForm(User user):this()
        {
            this.user = user;
            Home home = new Home();
            CloseForm();
            OpenForm(home);
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
        
        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            CloseForm();
            OpenForm(home);
        }

        private void btnPunchIn_Click(object sender, EventArgs e)
        {
            HealthInfoResident healthInfoResident = new HealthInfoResident(this.user);
            CloseForm();
            OpenForm(healthInfoResident);
        }

        private void btnMission_Click(object sender, EventArgs e)
        {
            Mission mission = new Mission(this.user);
            CloseForm();
            OpenForm(mission);
        }

        private void btnTravelExp_Click(object sender, EventArgs e)
        {
            TravelExperience travelExperience = new TravelExperience(this.user);
            CloseForm();
            OpenForm(travelExperience);
        }
        private void btnInformation_Click(object sender, EventArgs e)
        {
            InformationResident information = new InformationResident(this.user);
            CloseForm();
            OpenForm(information);
        }

        private void btnEmergency_Click(object sender, EventArgs e)
        {
            EmergencyForm emergency = new EmergencyForm(this.user);
            CloseForm();
            OpenForm(emergency);
        }

    }
}
