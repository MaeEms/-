using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityEpidemicManagementSystem
{
    public class TravelRecord
    {
        //出行记录序列号
        [Key]
        public string TravelRecordId { get; set; }

        public string UserId { set; get; }
        //出行记录的填写用户（对填写用户进行记录，防止恶意为他人填写）
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public string ResidentId { set; get; }
        //出行的成员
        [ForeignKey("ResidentId")]
        public virtual Resident Resident { set; get; }


        //出发地
        public string Departure { get; set; }

        //目的地
        public string Destination { get; set; }

        //出行日期
        public DateTime DateLeave { get; set; }

        //返回日期
        public DateTime DateCome { get; set; }


        //交通工具
        public string Transport { get; set; }

        //交通工具航班号/车次号
        public string TransportNumber { get; set; }

        //备注
        public string Remarks { get; set; }

        public TravelRecord()
        {
            /*
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                TravelRecordId = (Int16.Parse(entity.TravelRecords.Last().TravelRecordId) + 1).ToString();
            }*/
            TravelRecordId = Guid.NewGuid().ToString();
        }
        public TravelRecord(string id, User user, Resident resident, string departure, string destination, DateTime dateLeave,
            DateTime dateCome, string transport, string transportNumber, string remarks):this()
        {
            TravelRecordId = id;
            User = user;
            Resident = resident;
            Departure = departure;
            Destination = destination;
            DateLeave = dateLeave;
            DateCome = dateCome;
            Transport = transport;
            TransportNumber = transportNumber;
            Remarks = remarks;
        }
    }
}
