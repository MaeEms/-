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
    public partial class AdministratorTaskAdd : Form
    {
        public AdministratorTask AdministratorTask { get; set; }
        public AdministratorTaskAdd()
        {
            InitializeComponent();
        }

        public AdministratorTaskAdd(AdministratorTask administratorTask) : this()
        {
            AdministratorTask = administratorTask;
            AdministratorTaskBindingSource.DataSource = administratorTask;
            workerBindingSource.DataSource = WorkerService.GetAll();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            AdministratorTask.Server = workerBindingSource.Current as Worker;
        }
    }
}
