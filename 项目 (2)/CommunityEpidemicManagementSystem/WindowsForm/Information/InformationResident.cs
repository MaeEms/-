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
    public partial class InformationResident : Form
    {
        public User CurrentUser { get; set; }
        public InformationResident()
        {
            InitializeComponent();
        }

        public InformationResident(User user) : this()
        {
            CurrentUser = user;
            List<Resident> residents = ResidentService.QueryByUser(CurrentUser.UserId);
            InfoBindingSource.DataSource = residents;
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
                InfoBindingSource.DataSource = ResidentService.QueryByUser(CurrentUser.UserId);
                InfoBindingSource.ResetBindings(false);
            }
        }
    }
}
