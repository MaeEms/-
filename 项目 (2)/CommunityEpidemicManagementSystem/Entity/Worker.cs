using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityEpidemicManagementSystem
{
    public class Worker
    {
        [Key]
        public string WorkerId { set; get; }//工作人员id
        [Required]
        public string Name { set; get; }//工作人员姓名

        public string UserId { set; get; }
        [ForeignKey("UserId")]
        public virtual User User { set; get; }//用户名

        public Worker()
        {
            /*
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                WorkerId = (Int16.Parse(entity.Workers.Last().WorkerId) + 1).ToString();
            }*/
            WorkerId = Guid.NewGuid().ToString();
        }

        public Worker(string wokerId,string name,User user):this()
        {
            this.WorkerId = wokerId;
            this.Name = name;
            this.User = user;
        }
    }
}
