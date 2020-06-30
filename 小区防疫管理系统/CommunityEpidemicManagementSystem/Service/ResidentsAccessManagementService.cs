using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunityEpidemicManagementSystem
{
    public class ResidentsAccessManagementService
    {
        //获取全部
        public static List<ResidentAccessManagement> GetAll()
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                return entity.ResidentAccessManagements.ToList();
            }
        }
        //由ID获取
        public static ResidentAccessManagement Get(string id)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                return entity.ResidentAccessManagements.Find(id);
            }
        }
        //添加居民出入记录
        public static void AddRecord(ResidentAccessManagement rec)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                try
                {
                    entity.ResidentAccessManagements.Add(rec);
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
        //删除居民的出入记录
        public static void RemoveRecord(string id)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                try
                {
                    entity.ResidentAccessManagements.Remove(Get(id));
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
        //修改居民的出入记录
        public static void UpdateRecord(ResidentAccessManagement rec)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                try
                {
                    entity.Entry(rec).State = EntityState.Modified;

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
        //按居民ID查询
        public static List<ResidentAccessManagement> QueryByResidentID(string id)
        {
            //访问数据库，查询记录，返回记录
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.ResidentAccessManagements.Where(u => u.ResidentId == id);
                return query.ToList();
            }
        }
        //按日期查询
        public static List<ResidentAccessManagement> QueryByDate(DateTime date)
        {
            //访问数据库，查询记录，返回记录
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.ResidentAccessManagements.Where(u => u.AccessTime.Date == date.Date);
                return query.ToList();
            }
        }

    }
}
