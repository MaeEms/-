using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityEpidemicManagementSystem
{
    public class ResidentAccessManagement
    {
        public enum InOut
        {
            In = 0,
            Out =1
        }

        [Key]
        public string ResidentAccessManagementId { get; set; }//编号
        public double Tempreture { get; set; }//体温
        public DateTime AccessTime { get; set; }//出入时间
        public InOut In_Out { get; set; }//出入状态
        public string Notes { get; set; }//备注
        public string ResidentId { get; set; }

        [ForeignKey("ResidentId")]
        public virtual Resident Resident { get; set; }//居民

        public ResidentAccessManagement()
        {
            using (var entity = new CommunityEpidemicManagementSystemContext())
            {
                ResidentAccessManagementId = (Int16.Parse(entity.ResidentAccessManagements.Last().ResidentAccessManagementId) + 1).ToString();
            }
        }
        public ResidentAccessManagement(Resident res, double temp, InOut inout, string notes)
        {
            Resident = res;
            Tempreture = temp;
            In_Out = inout;
            Notes = notes;
        }

    }
}
