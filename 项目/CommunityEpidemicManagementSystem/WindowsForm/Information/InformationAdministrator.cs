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
    public partial class InformationAdministrator : Form
    {
        public User CurrentUser { get; set; }
        public InformationAdministrator()
        {
            InitializeComponent();
        }

        public InformationAdministrator(User user) : this()
        {
            CurrentUser = user;
            List<Resident> residents = ResidentService.GetAll();
            InfoBindingSource.DataSource = residents;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            switch (cmbQuery.SelectedIndex)
            {
                case 0: // 全部
                    InfoBindingSource.DataSource = ResidentService.GetAll();
                    break;
                case 1: // 根据姓名查询
                    InfoBindingSource.DataSource = ResidentService.QueryByName(txtQuery.Text);
                    break;
                case 2: // 根据用户名查询
                    InfoBindingSource.DataSource = ResidentService.QueryByUser(txtQuery.Text);
                    break;
                case 3://查询健康的居民
                    InfoBindingSource.DataSource = ResidentService.QueryByHealthStatus(HealthStatus.Health);
                    break;
                case 4://查询隔离的居民
                    InfoBindingSource.DataSource = ResidentService.QueryByHealthStatus(HealthStatus.quarantine);
                    break;
                case 5://查询患病的居民
                    InfoBindingSource.DataSource = ResidentService.QueryByHealthStatus(HealthStatus.sick);
                    break;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Resident resident = InfoBindingSource.Current as Resident;
            if (resident == null)
            {
                MessageBox.Show("请选择一个信息进行修改");
                return;
            }
            resident = ResidentService.Get(resident.ResidentId);
            InformationEdit informationEdit = new InformationEdit(resident);
            if (informationEdit.ShowDialog() == DialogResult.OK)
            {
                ResidentService.Update(informationEdit.Resident);
                InfoBindingSource.DataSource = ResidentService.GetAll();
                InfoBindingSource.ResetBindings(false);
            }
        }
    }
}
