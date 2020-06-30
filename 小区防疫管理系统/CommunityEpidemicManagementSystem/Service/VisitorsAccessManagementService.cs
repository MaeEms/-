using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityEpidemicManagementSystem
{
    public class VisitorsAccessManagementService
    {
        //获取全部
        public static List<VisitorAccessManagement> GetAll()
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                return entity.VisitorAccessManagements.ToList();
            }
        }
        //由ID获取
        public static VisitorAccessManagement Get(string id)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                return entity.VisitorAccessManagements.Find(id);
            }
        }
        //添加外来人员到访记录
        public static void AddRecord(VisitorAccessManagement rec)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                try
                {
                    entity.VisitorAccessManagements.Add(rec);
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
        //删除外来人员到访记录
        public static void RemoveRecord(string id)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                try
                {
                    entity.VisitorAccessManagements.Remove(Get(id));
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
        //修改外来人员到访记录
        public static void UpdateRecord(VisitorAccessManagement rec)
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
        //按姓名查询
        public static List<VisitorAccessManagement> QueryByName(string visName)
        {
            //访问数据库，查询记录，返回记录
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.VisitorAccessManagements.Where(u => u.Name == visName);
                return query.ToList();
            }
        }
        //按日期查询
        public static List<VisitorAccessManagement> QueryByDate(DateTime date)
        {
            //访问数据库，查询记录，返回记录
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.VisitorAccessManagements.Where(u => u.AccessTime.Date == date.Date);
                return query.ToList();
            }
        }
    }
}
