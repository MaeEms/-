using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityEpidemicManagementSystem
{
    public class WorkerService
    {
        public WorkerService()
        {

        }
        //获取全部
        public static List<Worker> GetAll()
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                return entity.Workers.ToList<Worker>();
            }
        }
        //由ID获取
        public static Worker Get(string id)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                return entity.Workers.Find(id);
            }
        }
        //添加
        public static void Add(Worker worker)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                try
                {
                    entity.Workers.Add(worker);
                    entity.SaveChanges();
                }
                catch(Exception ex)
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
                    throw new ApplicationException("添加时出错！\n" + $"{errorInfo}");
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
                    entity.Workers.Remove(Get(id));
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
        public static void Update(Worker worker)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                try
                {
                    entity.Entry(worker).State = EntityState.Modified;

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
        //按姓名查询
        public static List<Worker> QueryByName(string name)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.Workers.Where(u => u.Name == name);
                return query.ToList();
            }
        }
        //按用户名查询
        public static List<Worker> QueryByUser(string userid)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.Workers.Where(u => u.User.UserId == userid);
                return query.ToList();
            }
        }
        //按任务查找工作人员
        public static Worker QueryServerByTask(string taskid)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.AdministratorTasks.FirstOrDefault(u => u.AdministratorTaskId == taskid);

                return query.Server;
            }
        }
        //按任务查找管理员
        public static Worker QueryAdminByTask(string taskid)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.AdministratorTasks.FirstOrDefault(u => u.AdministratorTaskId == taskid);

                return query.Administrator;
            }
        }
        //按居民任务查找工作人员
        public static Worker QueryServerByMission(string missonid)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.ResidentMissions.FirstOrDefault(u => u.ResidentMissionId == missonid);

                return query.Server;
            }
        }
        //按委托查找
        public static List<Worker> QueryByFunc(Func<Worker,bool> func)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.Workers.Where(u => func(u));
                return query.ToList();
            }
        }
    }
}
