using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityEpidemicManagementSystem
{
    public enum EmergencyStatus
    {
        未处理 = 0,
        处理中 = 1,
        已完成 = 2
    }
    public partial class Emergency
    {
        
        [Key]
        public string EmergencyId { get; set; } //事件编号
        public string Address { get; set; } //事件地点
        public string Details { get; set; } //事件描述
        public EmergencyStatus EmergState { get; set; } //事件状态
        public DateTime RaiseTime { get; set; } //发生时间
        public string WorkerId { get; set; } //处理人id
        public string Notes { get; set; } //备注

        public string ResidentId { get; set; }
        [ForeignKey("ResidentId")]
        public virtual Resident Resident { get; set; } //用户名和id
        public Emergency()
        {
            /*using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                EmergencyId = (Int16.Parse(entity.Emergencies.Last().EmergencyId) + 1).ToString();
            }*/
            EmergencyId = Guid.NewGuid().ToString();
            EmergState = EmergencyStatus.已完成;
        }
        public Emergency(Resident res, string addr, string emergDetails, string notes):this()
        {
            this.Resident = res;
            this.Address = addr;
            this.Details = emergDetails;
            this.RaiseTime = DateTime.Now;
            this.Notes = notes;
        }
    }
}
