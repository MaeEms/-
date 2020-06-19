using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityEpidemicManagementSystem
{
    class HealthInformationService
    {
        //获取全部
        public static List<HealthInformation> GetAll()
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                return entity.HealthInformations.ToList<HealthInformation>();
            }
        }
        //由ID获取
        public static HealthInformation Get(string id)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                return entity.HealthInformations.Find(id);
            }
        }
        //健康记录每人每天一条，不多不少，因此构造方法即可，没有添加和删除方法
        //选中一条健康记录进行编辑-->就是健康打卡

        public static void Update(HealthInformation information)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                try
                {
                    entity.HealthInformations.Remove(Get(information.HealthInformationId));
                    entity.HealthInformations.Add(information);
                    if (information.HealthStatus == "健康"|| information.HealthStatus == "已治愈")
                    {
                        information.Resident.HealthStatus = HealthStatus.Health;
                    }else if(information.HealthStatus == "发热" || information.HealthStatus == "疑似")
                    {
                        information.Resident.HealthStatus = HealthStatus.quarantine;
                    }else if(information.HealthStatus == "确诊")
                    {
                        information.Resident.HealthStatus = HealthStatus.sick;
                    }
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
        //查询某个居民的所有打卡记录
        public static List<HealthInformation> QueryByResident(string ID)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.HealthInformations.Where(u => u.Resident.ResidentId == ID);
                return query.ToList();
            }
        }
        //查询某户的所有打卡记录
        public static List<HealthInformation> QueryByUser(string ID)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.HealthInformations.Where(u => u.Resident.User.UserId == ID);
                return query.ToList();
            }
        }
        //查询某个日期所有居民的打卡记录
        public static List<HealthInformation> QueryByDate(DateTime date)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.HealthInformations.Where(u => u.Date.Date == date.Date);
                return query.ToList();
            }
        }
        //按委托查找
        public static List<HealthInformation> QueryByFunc(Func<HealthInformation, bool> func)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.HealthInformations.Where(u => func(u));
                return query.ToList();
            }
        }

    }
}
