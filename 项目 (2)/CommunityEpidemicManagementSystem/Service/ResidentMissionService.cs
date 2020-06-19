using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityEpidemicManagementSystem
{
    public class ResidentMissionService
    {
        //获取全部
        public static List<ResidentMission> GetAll()
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                return entity.ResidentMissions.ToList<ResidentMission>();
            }
        }
        //由ID获取
        public static ResidentMission Get(string id)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                return entity.ResidentMissions.Find(id);
            }
        }
        //添加
        public static void Add(ResidentMission mission)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                try
                {
                    entity.ResidentMissions.Add(mission);
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
                    entity.ResidentMissions.Remove(Get(id));
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
        public static void Update(ResidentMission mission)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                try
                {
                    entity.ResidentMissions.Remove(Get(mission.ResidentMissionId));
                    entity.ResidentMissions.Add(mission);
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
        //按状态查询
        public static List<ResidentMission> QueryByStatus(MissionStatus status)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.ResidentMissions.Where(u => u.State == status);
                return query.ToList();
            }
        }
        //按用户id查询
        public static List<ResidentMission> QueryByUserId(string id)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.ResidentMissions.Where(u => u.Resident.User.UserId == id);
                return query.ToList();
            }
        }
        //按工作人员姓名查询
        public static List<ResidentMission> QueryByWorkerName(string name)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.ResidentMissions.Where(u => u.Server.Name == name);
                return query.ToList();
            }
        }
        //按用户id和状态查询
        public static List<ResidentMission> QueryByStatusAndId(string id, MissionStatus status)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.ResidentMissions.Where(u => u.Resident.User.UserId == id && u.State == status);
                return query.ToList();
            }
        }
        //按工作人员姓名和状态查询
        public static List<ResidentMission> QueryByStatusAndWorker(string name, MissionStatus status)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.ResidentMissions.Where(u => u.Server.Name == name && u.State == status);
                return query.ToList();
            }
        }
        //按时间查询
        public static List<ResidentMission> QuerydByDate(DateTime date)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.ResidentMissions.Where(t => t.CreatedTime == date);
                return query.ToList();
            }
        }

        //向任务添加工作人员
        public static void AddServerToMission(uint mission_id, Worker server)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                try
                {
                    entity.ResidentMissions.Find(mission_id).Server = server;
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
    }
}
