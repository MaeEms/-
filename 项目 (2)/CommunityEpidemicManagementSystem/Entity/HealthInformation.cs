using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityEpidemicManagementSystem
{
    public class HealthInformation
    {
        //健康信息记录的序号
        [Key]
        public string HealthInformationId { get; set; }
        //健康信息的登记时间
        public DateTime Date { get; set; }
        public string ResidentId { set; get; }
        //健康信息对应的居民对象
        [ForeignKey("ResidentId")]
        public virtual Resident Resident { get; set; }
        //居民的体温
        public double Temperature { get; set; }
        //居民的健康状态
        public string HealthStatus { get; set; }
        //备注
        public string Comment { get; set; }

        public HealthInformation()
        {/*
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                HealthInformationId = (Int16.Parse(entity.HealthInformations.Last().HealthInformationId) + 1).ToString();
            }
        */
            HealthInformationId = Guid.NewGuid().ToString();
        }
        public HealthInformation(Resident resident):this()
        {
            this.Resident = resident;
        }
    }
}
