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
    public partial class TravelExperienceEdit : Form
    {
        public TravelRecord record;
        public TravelExperienceEdit()
        {
            InitializeComponent();
        }

        public TravelExperienceEdit(TravelRecord record) : this()
        {
            this.record = record;
            this.TravelBindingSource.DataSource = record;
        }
    }
}
