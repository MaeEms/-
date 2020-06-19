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
    public partial class MissionAllocate : Form
    {
        public ResidentMission Mission { get; set; }
        public MissionAllocate()
        {
            InitializeComponent();
        }

        public MissionAllocate(ResidentMission mission) : this()
        {
            this.Mission = mission;
            this.MissionBindingSource.DataSource = mission;
        }
    }
}
