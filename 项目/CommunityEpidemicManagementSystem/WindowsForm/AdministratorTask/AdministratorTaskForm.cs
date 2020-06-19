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
    public partial class AdministratorTaskForm : Form
    {

        public AdministratorTaskForm()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

            switch (cmbQuery.SelectedIndex)
            {
                case 0://全部
                    AdministratorTaskBindingSource.DataSource = AdministratorTaskService.GetAll();
                    break;
                case 1://按任务编号查询
                    AdministratorTaskBindingSource.DataSource = AdministratorTaskService.Get(txtQuery.Text);
                    break;
                case 2://按工作人员姓名查询
                    AdministratorTaskBindingSource.DataSource = AdministratorTaskService.QueryTaskByServerName(txtQuery.Text);
                    break;
                case 3://按工作人员ID查询
                    AdministratorTaskBindingSource.DataSource = AdministratorTaskService.QueryTaskByServerID(txtQuery.Text);
                    break;
            }
            AdministratorTaskBindingSource.ResetBindings(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdministratorTaskAdd addAdministratorTask = new AdministratorTaskAdd(new AdministratorTask());
            if (addAdministratorTask.ShowDialog() == DialogResult.OK)
            {
                AdministratorTaskService.Add(addAdministratorTask.AdministratorTask);
                QueryAll();
            }
        }

        public void QueryAll()
        {
            AdministratorTaskBindingSource.DataSource = AdministratorTaskService.GetAll();
            AdministratorTaskBindingSource.ResetBindings(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AdministratorTask administratorTask = AdministratorTaskBindingSource.Current as AdministratorTask;
            if (administratorTask == null)
            {
                MessageBox.Show("请选择一项任务进行修改");
                return;
            }
            else
            {
                AdministratorTaskAdd addAdministratorTask = new AdministratorTaskAdd(administratorTask);
                if (addAdministratorTask.ShowDialog() == DialogResult.OK)
                {
                    AdministratorTaskService.Update(addAdministratorTask.AdministratorTask);
                    QueryAll();
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AdministratorTask administratorTask = AdministratorTaskBindingSource.Current as AdministratorTask;
            if (administratorTask == null)
            {
                MessageBox.Show("请选择要删除的任务");
                return;
            }
            else
            {
                AdministratorTaskService.Remove(administratorTask.AdministratorTaskId);
                QueryAll();
            }
        }
    }
}
