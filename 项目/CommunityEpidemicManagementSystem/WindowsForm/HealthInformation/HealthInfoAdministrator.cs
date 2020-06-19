using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ubiety.Dns.Core.Records;

namespace CommunityEpidemicManagementSystem
{
    public partial class HealthInfoAdministrator : Form
    {
        public User CurrentUser { get; set; }
        public HealthInfoAdministrator()
        {
            InitializeComponent();
        }

        public HealthInfoAdministrator(User user) : this()
        {
            CurrentUser = user;
            List<Resident> residents = ResidentService.GetAll();
            List<HealthInformation> healthInformation = null;
            for (int i = 0; i < residents.Count(); i++)
            {
                healthInformation.Add(new HealthInformation(residents[i]));
            }
            HealthBindingSource.DataSource = healthInformation;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (cmbQuery.SelectedIndex)
            {
                case 0: // 全部
                    HealthBindingSource.DataSource = HealthInformationService.GetAll();
                    break;
                case 1: // 按居民ID查询
                    HealthBindingSource.DataSource = HealthInformationService.QueryByResident(txtQuery.Text);
                    break;
                case 2: // 按用户ID查询
                    HealthBindingSource.DataSource = HealthInformationService.QueryByUser(txtQuery.Text);
                    break;
                case 3: // 按日期查询
                    DateTime dt = Convert.ToDateTime(txtQuery.Text);
                    HealthBindingSource.DataSource = HealthInformationService.QueryByDate(dt);
                    break;
            }
            HealthBindingSource.ResetBindings(true);
        }
    }
}
