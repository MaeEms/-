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
    public partial class HealthInfoEdit : Form
    {
        HealthInformation information;
        public HealthInfoEdit()
        {
            InitializeComponent();
        }

        public HealthInfoEdit(HealthInformation information) : this()
        {
            this.information = information;
            this.HealthBindingSource.DataSource = information;
            this.txtName.Text = ResidentService.Get(this.information.Resident.ResidentId).Name;
            this.txtId.Text = ResidentService.Get(this.information.Resident.ResidentId).ResidentId;
        }

        public void HealthStatusEdit(HealthInformation information)
        {
            if (cmbHealthyStatus.SelectedIndex == 0)
                information.Resident.HealthStatus = HealthStatus.Health;
            else if (cmbHealthyStatus.SelectedIndex == 1)
                information.Resident.HealthStatus = HealthStatus.quarantine;
            else
                information.Resident.HealthStatus = HealthStatus.sick;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
           
        }
    }
}
