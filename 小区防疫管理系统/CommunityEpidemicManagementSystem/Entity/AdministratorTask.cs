using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityEpidemicManagementSystem
{
    public enum TaskStatus
    {
        Unfinished = 0,
        Finished = 1
    }

    public class AdministratorTask
    {
        
        [Key]
        public string AdministratorTaskId { get; set; }//任务id
        public string Description { get; set; }//任务描述
        public DateTime CreatedTime { get; set; }//创建时间
        public DateTime DDLTime { get; set; }//截止时间
        public TaskStatus State { get; set; }//任务状态
        public string Remark { get; set; }///备注
        public Worker Server { get; set; }//工作人员
        public Worker Administrator { get; set; }//管理员
        public AdministratorTask()
        {/*
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                AdministratorTaskId = (Int16.Parse(entity.AdministratorTasks.Last().AdministratorTaskId) + 1).ToString();
            }*/

            AdministratorTaskId = Guid.NewGuid().ToString();
            CreatedTime = DateTime.Now;
        }
        public AdministratorTask(string id, string description, DateTime ddl_time, Worker administrator):this()
        {
            this.AdministratorTaskId = id;
            this.Description = description;
            this.DDLTime = ddl_time;
            this.Administrator = administrator;
            this.State = TaskStatus.Unfinished;
        }
    }
}
