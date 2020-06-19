using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityEpidemicManagementSystem
{
    public class UserService
    {
        //获取全部
        public static List<User> GetAll()
        {
            using(var entity = new CommunityEpidemicManagementSystemContext())
            {
                return entity.Users.ToList<User>();
            }
        }
        //由ID获取
        public static User Get(string id)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                return entity.Users.Find(id);
            }

        }
        //添加
        public static void Add(User user)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                if(Get(user.UserId) != null)
                {
                    throw new ApplicationException("已经存在！");
                }

                try
                    {
                    entity.Users.Add(user);
                    entity.SaveChanges();
                }
                catch(Exception ex)
                {
                    string errorInfo = ex.Message;
                    if(ex is DbEntityValidationException)
                    {
                        foreach (var validationResult in ((DbEntityValidationException)ex).EntityValidationErrors)
                        {
                            foreach (var error in validationResult.ValidationErrors)
                            {
                                errorInfo = $"{errorInfo}"+"\n"+$"{error.ErrorMessage}";        
                            }
                        }
                    }
                    throw new ApplicationException("添加时出错！\n"+$"{errorInfo}");
                }
            }
        }
        //删除
        public static void Remove(string id)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                try
                {
                    entity.Users.Remove(Get(id));
                    entity.SaveChanges();
                }
                catch (Exception ex)
                {
                    string errorInfo = ex.Message;
                    if (ex is DbEntityValidationException)
                    {
                        foreach (var validationResult in ((DbEntityValidationException)ex).EntityValidationErrors)
                        {
                            foreach (var error in validationResult.ValidationErrors)
                            {
                                errorInfo = $"{errorInfo}" + "\n" + $"{error.ErrorMessage}";
                            }
                        }
                    }
                    throw new ApplicationException("删除时出错！\n" + $"{errorInfo}");
                }
            }
        }
        //更新
        public static void Update(User user)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                try
                {
                    entity.Users.Remove(Get(user.UserId));
                    entity.Users.Add(user);
                    entity.SaveChanges();
                }
                catch (Exception ex)
                {
                    string errorInfo = ex.Message;
                    if (ex is DbEntityValidationException)
                    {
                        foreach (var validationResult in ((DbEntityValidationException)ex).EntityValidationErrors)
                        {
                            foreach (var error in validationResult.ValidationErrors)
                            {
                                errorInfo = $"{errorInfo}" + "\n" + $"{error.ErrorMessage}";
                            }
                        }
                    }
                    throw new ApplicationException("更新时出错！\n" + $"{errorInfo}");
                }
            }
        }
        //按用户类型查询
        public static List<User> QueryByType(UserType type)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.Users.Where(u => u.UserType == type);
                return query.ToList();
            }
        }
        //按委托查询
        public static List<User> QueryByFunc(Func<User,bool> func)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.Users.Where(u=>func(u));
                return query.ToList();
            }
        }
    }
}
