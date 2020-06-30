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
    public partial class EmergencyAllocate : Form
    {
        public Emergency emergency { get; set; }
        public EmergencyAllocate()
        {
            InitializeComponent();
        }
        public EmergencyAllocate(Emergency emergency) : this()
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Worker worker = WorkerBindingSource.Current as Worker;
            emergency.WorkerId = worker.WorkerId;
        }
    }
}
