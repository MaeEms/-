using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityEpidemicManagementSystem
{
    public class VisitorAccessManagement
    {
        [Key]
        public string VisitorAccessManagementId { get; set; } //出入记录的编号

        public string Name { get; set; }//visitor的姓名
        public string IDCard { get; set; }//visitor的身份证号

        public string PhoneNumber { get; set; }//联系方式
        public string HealthState { get; set; }//健康状态
        public double Tempreture { get; set; }//体温

        public DateTime AccessTime { get; set; }//访问时间
        public string AccessPurpose { get; set; }//访问目的

        public DateTime LeaveTime { get; set; }//离开时间：点击button后系统自动填写

        public string Notes { get; set; }//备注
        public VisitorAccessManagement()
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                VisitorAccessManagementId = (Int16.Parse(entity.VisitorAccessManagements.Last().VisitorAccessManagementId) + 1).ToString();
            }
            AccessTime = DateTime.Now;
        }
        public VisitorAccessManagement(string name, string visHealth, double temp, string phoneNumber)
        {
            Name = name;
            HealthState = visHealth;
            Tempreture = temp;
            PhoneNumber = phoneNumber;
        }

    }
}
