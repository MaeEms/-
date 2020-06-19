using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunityEpidemicManagementSystem
{

    public enum HealthStatus
    {
        Health=0,
        quarantine = 1,
        sick=2

    }
    public class Resident
    {
        [Key]
        public string ResidentId { set; get; }//居民id
        [Required]
        public string Name { set; get; }//居民姓名

        public HealthStatus HealthStatus { get; set; }//居民健康状况
        public string UserId { set; get; }
        [ForeignKey("UserId")]
        public virtual User User { set; get; }//用户
        public Resident()
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                ResidentId = (Int16.Parse(entity.Residents.Last().ResidentId) + 1).ToString();
            }
        }
        public Resident(string residentId,string name,User user):this()
        {
            this.ResidentId = residentId;
            this.Name = name;
            this.User = user;
        }
    }
}
