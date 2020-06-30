using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityEpidemicManagementSystem
{
    public class AdministratorTaskService
    {
        //获取全部
        public static List<AdministratorTask> GetAll()
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                return entity.AdministratorTasks.ToList();
            }
        }

        //获取某工作人员全部已完成的
        public static List<AdministratorTask> QueryAllFinishedTask(Worker worker)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.AdministratorTasks.Where(t => t.State == TaskStatus.Finished && t.Server == worker);
                return query.ToList();
            }
        }

        //由ID获取
        public static AdministratorTask Get(string task_id)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                return entity.AdministratorTasks.Find(task_id);
            }
        }
        //由ID获取某工作人员已完成的
        public static List<AdministratorTask> GetFinishedByID(string task_id, Worker worker)
        {


            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.AdministratorTasks.Where(t => t.Server == worker && t.State == TaskStatus.Finished && t.AdministratorTaskId == task_id);
                return query.ToList();
            }

        }
        //新增
        public static void Add(AdministratorTask task)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {

                try
                {
                    entity.AdministratorTasks.Add(task);
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
                    throw new ApplicationException("添加时出错！\n" + $"{errorInfo}");
                }
            }

        }
        //删除
        public static void Remove(string task_id)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                try
                {
                    AdministratorTask task = Get(task_id);
                    entity.AdministratorTasks.Remove(task);
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
        public static void Update(AdministratorTask task)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                try
                {
                    entity.Entry(task).State = EntityState.Modified;

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
        //给订单分配工作人员
        public static void AddServerToTask(string task_id, Worker server)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                try
                {
                    AdministratorTask task = Get(task_id);
                    entity.AdministratorTasks.Remove(task);
                    task.Server = server;
                    entity.AdministratorTasks.Add(task);
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
                    throw new ApplicationException("分配时出错！\n" + $"{errorInfo}");
                }
            }
        }
        //按工作人员查询
        public static List<AdministratorTask> QueryTaskByServer(Worker server)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.AdministratorTasks.Where(t => t.Server == server);
                return query.ToList();
            }
        }
        //查询工作人员未完成的
        public static List<AdministratorTask> QueryUnFinishedTaskByServer(Worker server)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.AdministratorTasks.Where(t => t.Server == server && t.State == TaskStatus.Unfinished);
                return query.ToList();
            }
        }

        //查询工作人员已完成的
        public static List<AdministratorTask> QueryFinishedTaskByServer(Worker server)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.AdministratorTasks.Where(t => t.Server == server && t.State == TaskStatus.Finished);
                return query.ToList();
            }
        }
        //按工作人员姓名查询
        public static List<AdministratorTask> QueryTaskByServerName(string name)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.AdministratorTasks.Where(t => t.Server.Name == name);
                return query.ToList();
            }
        }

        //按工作人员ID查询
        public static List<AdministratorTask> QueryTaskByServerID(string id)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.AdministratorTasks.Where(t => t.Server.WorkerId == id);
                return query.ToList();
            }
        }

        //按工作人员ID查询已完成的
        public static List<AdministratorTask> QueryFinishedTaskByServerID(string id, Worker worker)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.AdministratorTasks.Where(t => t.Server.WorkerId == id && t.State == TaskStatus.Finished && t.Server == worker);
                return query.ToList();
            }
        }

        //按创建日期查询
        public static List<AdministratorTask> QueryTaskByCreateDate(DateTime dateTime)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.AdministratorTasks.Where(t => t.CreatedTime == dateTime);
                return query.ToList();
            }
        }

        //按创建日期查询某工作人员已完成的
        public static List<AdministratorTask> QueryFinishedTaskByCreateDate(DateTime dateTime, Worker worker)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.AdministratorTasks.Where(t => t.CreatedTime == dateTime && t.State == TaskStatus.Finished && t.Server == worker);
                return query.ToList();
            }
        }
        //按截止时间查询
        public static List<AdministratorTask> QueryTaskByDDLDate(DateTime dateTime)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.AdministratorTasks.Where(t => t.DDLTime == dateTime);
                return query.ToList();
            }
        }

        //按截止时间查询某工作人员已完成的
        public static List<AdministratorTask> QueryFinshedTaskByDDLDate(DateTime dateTime, Worker worker)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.AdministratorTasks.Where(t => t.DDLTime == dateTime && t.State == TaskStatus.Finished && t.Server == worker);
                return query.ToList();
            }
        }
    }
}
