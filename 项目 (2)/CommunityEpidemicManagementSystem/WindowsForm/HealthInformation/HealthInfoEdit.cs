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
        }
    }
}
