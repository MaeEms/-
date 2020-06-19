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
    public partial class AccessManagement : Form
    {
        public User CurrentUser { get; set; }
        public AccessManagement()
        {
            InitializeComponent();
        }

        //居民没有此界面，管理员和工作人员权限一致，故没有身份判断
        public AccessManagement(User user) : this()
        {
            ResidentAccessManagementBindingSource.DataSource = ResidentsAccessManagementService.GetAll();

        }


        private void btnQuery_Click(object sender, EventArgs e)
        {
            switch (cmbQuery.SelectedIndex)
            {
                case 0://全部
                    ResidentAccessManagementBindingSource.DataSource = ResidentsAccessManagementService.GetAll();
                    break;
                case 1://按编号查询
                    ResidentAccessManagementBindingSource.DataSource = ResidentsAccessManagementService.QueryByResidentID(txtQuery.Text);
                    break;
                case 2://按日期查询
                    ResidentAccessManagementBindingSource.DataSource = ResidentsAccessManagementService.QueryByDate(DateTime.Parse(txtQuery.Text));
                    break;
                default: break;
            }
            ResidentAccessManagementBindingSource.ResetBindings(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AccessManagementAdd addAccessManagement = new AccessManagementAdd(new ResidentAccessManagement());
            if (addAccessManagement.ShowDialog() == DialogResult.OK)
            {
                ResidentsAccessManagementService.AddRecord(addAccessManagement.ResidentAccess);
                ResidentQueryALL();
            }
        }


        private void ResidentQueryALL()
        {
            ResidentAccessManagementBindingSource.DataSource = ResidentsAccessManagementService.GetAll();
            ResidentAccessManagementBindingSource.ResetBindings(false);
        }

        private void VisitorQueryALL()
        {
            VisitorAccessManagementBindingSource.DataSource = VisitorsAccessManagementService.GetAll();
            VisitorAccessManagementBindingSource.ResetBindings(false);
        }


        private void btnQueryOut_Click(object sender, EventArgs e)
        {
            switch (cmbQueryOut.SelectedIndex)
            {
                case 0://全部
                    VisitorAccessManagementBindingSource.DataSource = VisitorsAccessManagementService.GetAll();
                    break;
                case 1://按姓名查询
                    VisitorAccessManagementBindingSource.DataSource = VisitorsAccessManagementService.QueryByName(txtQueryOut.Text);
                    break;
                case 2://按日期查询
                    VisitorAccessManagementBindingSource.DataSource = VisitorsAccessManagementService.QueryByDate(DateTime.Parse(txtQueryOut.Text));
                    break;
                default:
                    break;
            }
            VisitorAccessManagementBindingSource.ResetBindings(true);
        }

        private void btnAddOut_Click(object sender, EventArgs e)
        {
            AccessManagementAddOut addOutAccess = new AccessManagementAddOut(new VisitorAccessManagement());
            if (addOutAccess.ShowDialog() == DialogResult.OK)
            {
                VisitorsAccessManagementService.AddRecord(addOutAccess.VisitorAccessManagement);
                VisitorQueryALL();
            }
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            VisitorAccessManagement visitorAccessManagement = VisitorAccessManagementBindingSource.Current as VisitorAccessManagement;
            if (visitorAccessManagement == null)
            {
                MessageBox.Show("请选择一位访客");
                return;
            }
            else
            {
                visitorAccessManagement.LeaveTime = DateTime.Now;
                VisitorsAccessManagementService.UpdateRecord(visitorAccessManagement);
                VisitorQueryALL();

            }

        }
    }


}
