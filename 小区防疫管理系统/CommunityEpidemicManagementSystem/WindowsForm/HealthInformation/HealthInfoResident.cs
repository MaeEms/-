using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunityEpidemicManagementSystem
{
    public partial class HealthInfoResident : Form
    {
        public User CurrentUser { get; set; }
        public HealthInfoResident()
        {
            InitializeComponent();
        }
        public HealthInfoResident(User user):this()
        {
            List<HealthInformation> healthInformation = new List<HealthInformation>();

            CurrentUser = user;
            List<Resident> residents = ResidentService.QueryByUser(CurrentUser.UserId);
            
            foreach(Resident res in residents)
            {
                HealthInformation info = new HealthInformation(res);

                healthInformation.Add(info);
                HealthInformationService.Add(info);
            }/*
            for(int i = 0; i < residents.Count; i++)
            {
                healthInformation.Add(new HealthInformation(residents[i]));
            }*/
            TodayBindingSource.DataSource = healthInformation;
            HealthBindingSource.DataSource = HealthInformationService.QueryByUser(CurrentUser.UserId);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            HealthInformation information = TodayBindingSource.Current as HealthInformation;
            if(information == null)
            {
                MessageBox.Show("请选择一个打卡信息进行修改");
                return;
            }
            HealthInfoEdit infoEdit = new HealthInfoEdit(information);
            if(infoEdit.ShowDialog() == DialogResult.OK)
            {
                infoEdit.HealthStatusEdit(information);
                information.Date = DateTime.Now;
                HealthBindingSource.DataSource = HealthInformationService.QueryByUser(CurrentUser.UserId);
                TodayBindingSource.ResetBindings(false);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            foreach (var h in TodayBindingSource)
            {
                HealthInformation health = h as HealthInformation;
                if(health.HealthStatus == null)
                {
                    MessageBox.Show("请全部填写后提交！");
                    return;
                }
            }
            MessageBox.Show("提交成功！");
            return;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            switch (cmbQuery.SelectedIndex)
            {
                case 0: // 全部
                    List<HealthInformation> informations = HealthInformationService.QueryByUser(CurrentUser.UserId);
                    HealthBindingSource.DataSource = informations;
                    break;
                case 1: // 按居民ID查询
                    informations = HealthInformationService.QueryByUser(CurrentUser.UserId);
                    List<HealthInformation> temp = new List<HealthInformation>();
                    var list = from HealthInformation h in informations
                               where h.Resident.ResidentId == txtQuery.Text
                               select h;
                    temp = list.ToList();
                    HealthBindingSource.DataSource = HealthInformationService.QueryByResident(txtQuery.Text);
                    break;
                case 2: // 按日期查询
                    DateTime dt = Convert.ToDateTime(txtQuery.Text);
                    informations = HealthInformationService.QueryByUser(CurrentUser.UserId);
                    var date = from HealthInformation h in informations
                               where h.Date == dt
                               select h;
                    temp = date.ToList();
                    HealthBindingSource.DataSource = temp;
                    break;
            }
            HealthBindingSource.ResetBindings(true);
        }
    }
}
