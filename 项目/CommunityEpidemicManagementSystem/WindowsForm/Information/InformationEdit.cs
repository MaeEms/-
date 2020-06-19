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
    public partial class InformationEdit : Form
    {
        public Resident Resident { get; set; }
        public InformationEdit()
        {
            InitializeComponent();
        }

        public InformationEdit(Resident resident) : this()
        {
            this.Resident = resident;
            this.ResidentBindingSource.DataSource = resident;
        }
    }
}
