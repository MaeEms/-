using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunityEpidemicManagementSystem
{
    public partial class WorkerTask : Form
    {
        public Worker CurrentWorker { get; set; }
        public WorkerTask()
        {
            InitializeComponent();
        }




        private void btnQuery_Click(object sender, EventArgs e)
        {
            switch (cmbQuery.SelectedIndex)
            {
                case 0:// 全部
                    WorkerTaskBindingSource.DataSource = AdministratorTaskService.QueryFinishedTaskByServer(CurrentWorker);
                    break;
                case 1://按编号查询
                    WorkerTaskBindingSource.DataSource = AdministratorTaskService.GetFinishedByID(txtQuery.Text, CurrentWorker);
                    break;
                case 2://按创建日期查询

                    WorkerTaskBindingSource.DataSource = AdministratorTaskService.QueryFinishedTaskByCreateDate(DateTime.Parse(txtQuery.Text), CurrentWorker);
                    break;
                case 3://按截止日期查询
                    WorkerTaskBindingSource.DataSource = AdministratorTaskService.QueryFinshedTaskByDDLDate(DateTime.Parse(txtQuery.Text), CurrentWorker);
                    break;
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            AdministratorTask administratorTask = WorkerTaskBindingSource.Current as AdministratorTask;
            if (administratorTask == null)
            {
                MessageBox.Show("请选择要完成的任务");
                return;
            }
            else
            {
                administratorTask.State = TaskStatus.Finished;

                QueryUnFinished(CurrentWorker);
            }
        }

        private void QueryUnFinished(Worker worker)
        {
            WorkerTaskBindingSource.DataSource = AdministratorTaskService.QueryUnFinishedTaskByServer(worker);
            WorkerTaskBindingSource.ResetBindings(false);
        }


    }
}
