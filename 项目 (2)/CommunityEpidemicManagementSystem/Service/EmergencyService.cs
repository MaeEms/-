using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityEpidemicManagementSystem
{
    public class EmergencyService
    {
        //获取全部
        public static List<Emergency> GetAll()
        {
            using(var entity = new CommunityEpidemicManagementSystemContext())
            {
                return entity.Emergencies.ToList();
            }
        }
        //由ID获取
        public static Emergency Get(string id)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                return entity.Emergencies.Find(id);
            }
        }
        //添加紧急事件
        public static void Add(Emergency emerg)
        {
            try
            {
                using (var entity = new CommunityEpidemicManagementSystemContext())
                {
                    entity.Emergencies.Add(emerg);
                    entity.SaveChanges();
                }
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
        //删除
        public void Remove(string id)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                try
                {
                    entity.Emergencies.Remove(Get(id));
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
        public static void Update(Emergency emergency)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                try
                {
                    entity.Emergencies.Remove(Get(emergency.EmergencyId));
                    entity.Emergencies.Add(emergency);
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
        //按用户名查询
        public static List<Emergency> QueryByName(string userName)
        {
            //访问数据库，查询记录，返回记录
            using (var db = new CommunityEpidemicManagementSystemContext())
            {
                var query = db.Emergencies.Where(e => e.Resident.Name == userName);
                return query.ToList();
            }
        }
        //按处理人查询
        public static List<Emergency> QueryByWorker(string wkrId)
        {
            //访问数据库，查询记录，返回记录
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.Emergencies.Where(e => e.WorkerId == wkrId);
                return query.ToList();
            }
        }
        //按状态查询
        public static List<Emergency> QueryByStatus(EmergencyStatus status)
        {
            //访问数据库，查询记录，返回记录
            using (var db = new CommunityEpidemicManagementSystemContext())
            {
                var query = db.Emergencies.Where(e => e.EmergState == status);
                return query.ToList();
            }
        }
        //按用户ID和状态查询
        public static List<Emergency> QueryByIdAndStatus(string id, EmergencyStatus status)
        {
            //访问数据库，查询记录，返回记录
            using (var db = new CommunityEpidemicManagementSystemContext())
            {
                var query = db.Emergencies.Where(e => e.Resident.ResidentId==id && e.EmergState == status);
                return query.ToList();
            }
        }
        //按工作人员和状态查询
        public static List<Emergency> QueryByWorkerAndStatus(string id, EmergencyStatus status)
        {
            //访问数据库，查询记录，返回记录
            using (var db = new CommunityEpidemicManagementSystemContext())
            {
                var query = db.Emergencies.Where(e => e.WorkerId == id && e.EmergState == status);
                return query.ToList();
            }
        }
        //按事件关键词查询
        /*
        public Emergency QueryEmergenciesByKeywords(string detls)
        {
            //访问数据库，查询记录，返回记录
        }
        */

    }
}
