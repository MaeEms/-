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
        Health = 0,
        quarantine = 1,
        sick = 2

    }
    public class Resident
    {
        [Key]
        public string ResidentId { set; get; }//居民id
        [Required]
        public string Name { set; get; }//居民姓名
        public string Sex { get; set; }//居民性别
        public int Age { get; set; }//居民年龄
        public string IdCard { get; set; }//居民身份证号
        public string Phone { get; set; }//居民联系方式
        public string Relationship { get; set; }//与户主关系
        public string Notes { get; set; }//备注
        public HealthStatus HealthStatus { get; set; }//居民健康状况
        public string UserId { set; get; }
        [ForeignKey("UserId")]
        public virtual User User { set; get; }//用户
        public Resident()
        {
            /*
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                ResidentId = (Int16.Parse(entity.Residents.Last().ResidentId) + 1).ToString();
            }*/
            ResidentId = Guid.NewGuid().ToString();

        }
        public Resident(string residentId, string name, User user) : this()
        {
            this.ResidentId = residentId;
            this.Name = name;
            this.User = user;
            CardId(this.IdCard);
        }

        public Resident(string name, string idCard,String phoneNumber, string relationship,string notes,User user) 
        {
            ResidentId = Guid.NewGuid().ToString();
            IdCard = idCard;
            Phone = phoneNumber;
            this.Name = name;
            this.User = user;
            Notes = notes;
            Relationship = relationship;
            CardId(this.IdCard);
        }
        public void CardId(string id)
        {
            if (id[16] % 2 == 0)
                this.Sex = "女";
            else
                this.Sex = "男";

            Age = 2020 - int.Parse(id.Substring(6, 4));
        }
    }
}
