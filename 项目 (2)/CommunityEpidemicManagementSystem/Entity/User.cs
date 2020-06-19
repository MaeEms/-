using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityEpidemicManagementSystem
{
    public enum UserType
    {
        Resident = 0,
        Worker = 1,
        Administrator = 2
    }

    public class User
    {
        [Key]
        public string UserId { set; get; }//用户ID
        [Required]
        public string Password { set; get; }//用户密码
        [Required]
        public UserType UserType { set; get; }//用户类别

        public User()
        {
            /*
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                UserId =(Int16.Parse(entity.Users.Last().UserId) + 1).ToString();
            }*/
            UserId = Guid.NewGuid().ToString();
            this.UserType = UserType.Resident;
        }
        public User(string userId,string password,UserType usertype):this()
        {
            this.UserId = userId;
            this.Password = password;
            this.UserType = usertype;
        }
    }
}
