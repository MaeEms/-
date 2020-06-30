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
    public partial class AccessManagementAdd : Form
    {
        public ResidentAccessManagement ResidentAccess { get; set; }
        public AccessManagementAdd()
        {
            InitializeComponent();
        }
        public AccessManagementAdd(ResidentAccessManagement residentAccess) : this()
        {
            ResidentAccess = residentAccess;
            ResidentAccessBindingSource.DataSource = residentAccess;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            HealthStatus HealthStatus = ResidentService.Get(txtId.Text).HealthStatus;
            if (HealthStatus == HealthStatus.Health)
            {
                MessageBox.Show("该居民健康，可以放行");
            }
            else if (HealthStatus == HealthStatus.quarantine)
            {
                MessageBox.Show("该居民隔离，不建议放行");
            }
            else if (HealthStatus == HealthStatus.sick)
            {
                MessageBox.Show("该居民患病，不能放行");
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbAccess.SelectedIndex == 0)
                ResidentAccess.In_Out = ResidentAccessManagement.InOut.In;
            else
                ResidentAccess.In_Out = ResidentAccessManagement.InOut.Out;
        }
    }
}
