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
    public partial class AccessManagementAddOut : Form
    {
        public VisitorAccessManagement VisitorAccessManagement { get; set; }
        public AccessManagementAddOut()
        {
            InitializeComponent();
        }

        public AccessManagementAddOut(VisitorAccessManagement visitorAccessManagement) : this()
        {
            VisitorAccessManagement = visitorAccessManagement;
            VisitorAccessBindingSource.DataSource = visitorAccessManagement;
        }
    }
}
