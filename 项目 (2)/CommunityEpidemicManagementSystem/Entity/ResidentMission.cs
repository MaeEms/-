using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityEpidemicManagementSystem
{
    public enum MissionStatus
    {
        未接受 = 0,
        已接受 = 1,
        已完成 = 2,
        拒绝 = 3
    }
    public class ResidentMission
    {
        [Key]
        public string ResidentMissionId { get; set; }//任务id
        public string Title { get; set; }//任务标题
        public string Description { get; set; }//任务描述
        public DateTime CreatedTime { get; set; }//创建时间
        public DateTime DDLTime { get; set; }//截止时间
        public DateTime FinishedTime { get; set; }//完成时间
        public MissionStatus State { get; set; }//任务状态
        public Worker Server { get; set; }//工作人员
        public string Remark { get; set; }//任务备注
        public string ResidentId { set; get; }
        [ForeignKey("ResidentId")]
        public virtual Resident Resident { get; set; }//居民
        public ResidentMission()
        {
            /*
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                ResidentMissionId = (Int16.Parse(entity.ResidentMissions.Last().ResidentMissionId) + 1).ToString();
            }*/
            ResidentMissionId = Guid.NewGuid().ToString();
            CreatedTime = DateTime.Now;
        }
        public ResidentMission(string id, string description, DateTime ddl_time, Resident resident)
        {
            ResidentMissionId = id;
            Description = description;
            DDLTime = ddl_time;
            Resident = resident;
        }
    }
}
