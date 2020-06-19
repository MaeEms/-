using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityEpidemicManagementSystem
{
    public class ResidentService
    {
        public ResidentService()
        {

        }
        //获取全部
        public static List<Resident> GetAll()
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                return entity.Residents.ToList<Resident>();
            }
        }
        //由ID获取
        public static Resident Get(string id)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                return entity.Residents.Find(id);
            }
        }
        //添加
        public static void Add(Resident resident)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                try
                {
                    entity.Residents.Add(resident);
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
        public static void Remove(string id)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                try
                {
                    entity.Residents.Remove(Get(id));
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
        public static void Update(Resident resident)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                try
                {
                    entity.Residents.Remove(Get(resident.ResidentId));
                    entity.Residents.Add(resident);
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
        public static List<Resident> QueryByName(string name)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.Residents.Where(u => u.Name == name);
                return query.ToList();
            }
        }

        //按健康状态查询居民
        public static List<Resident> QueryByHealthStatus(HealthStatus healthStatus)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.Residents.Where(u => u.HealthStatus == healthStatus);
                return query.ToList();
            }
        }

        //按用户名查询
        public static List<Resident> QueryByUser(string userid)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.Residents.Where(u => u.User.UserId == userid);
                return query.ToList();
            }
        }
        //按任务查询
        public static List<Resident> QueryByMission(string missonid)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.ResidentMissions.Where(u => u.ResidentMissionId == missonid);
                List<Resident> list = new List<Resident>();
                query.ToList().ForEach(o => list.Add(o.Resident));
                return list;
            }
        }
        //按委托查询
        public static List<Resident> QueryByFunc(Func<Resident, bool> func)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.Residents.Where(u => func(u));
                return query.ToList();
            }
        }
    }
}
