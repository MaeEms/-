using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityEpidemicManagementSystem
{
    class TravelRecordService
    {
        //由ID获取出行经历
        public static TravelRecord Get(string id)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                return entity.TravelRecords.Find(id);
            }
        }
        //获取全部出行经历
        public static List<TravelRecord> GetAll()
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                return entity.TravelRecords.ToList<TravelRecord>();
            }
        }
        //添加一条出行经历
        public static void Add(TravelRecord travelRecord)
        {
            //生成一条旅行经历加入数据库
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                //在点击事件中创建新对象时，要记得生成一个ID
                // string ID = Guid.NewGuid().ToString();
                // TravelRecord tr = new TravelRecord(ID,user,resident,departure,destination,dateLeave,dateCome,
                //    transport,transportNumber,remarks);
                try
                {
                    entity.TravelRecords.Add(travelRecord);
                    entity.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        //删除一条出行经历
        public static void Remove(string id)
        {

            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                try
                {
                    entity.TravelRecords.Remove(Get(id));
                    entity.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        //修改一条出行经历
        public static void Update(TravelRecord TravelRecord)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {

                try
                {
                    entity.TravelRecords.Remove(Get(TravelRecord.TravelRecordId));
                    entity.TravelRecords.Add(TravelRecord);
                    entity.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        //按居民ID查询出行经历
        public static List<TravelRecord> QueryByResidentID(string ID)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.TravelRecords.Where(t => t.Resident.ResidentId == ID);
                return query.ToList();
            }

        }
        //查询一户的出行经历
        public static List<TravelRecord> QueryByUserID(String ID)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.TravelRecords.Where(t => t.User.UserId == ID);
                return query.ToList();
            }
        }
        //查询某一天出发的的出行情况
        public static List<TravelRecord> QuerydByDateLeave(DateTime date)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.TravelRecords.Where(t => t.DateLeave == date);
                return query.ToList();
            }
        }
        //查询某一天出发的的出行情况
        public static List<TravelRecord> QueryTravelRecordByDateCome(DateTime date)
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                var query = entity.TravelRecords.Where(t => t.DateCome == date);
                return query.ToList();
            }
        }
    }

}
