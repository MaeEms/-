using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityEpidemicManagementSystem
{
    public class CommunityEpidemicManagementSystemContext : DbContext
    {
        public CommunityEpidemicManagementSystemContext() : base("CommunityEpidemicManagementSystemDatabase")
        {
            Database.SetInitializer(
            new DropCreateDatabaseIfModelChanges<CommunityEpidemicManagementSystemContext>());
        }

        public DbSet<AdministratorTask> AdministratorTasks{ get; set; }
        public DbSet<Emergency> Emergencies { get; set; }
        public DbSet<HealthInformation> HealthInformations { get; set; }
        public DbSet<Resident> Residents { get; set; }
        public DbSet<ResidentAccessManagement> ResidentAccessManagements { get; set; }
        public DbSet<ResidentMission> ResidentMissions { get; set; }
        public DbSet<TravelRecord> TravelRecords { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<VisitorAccessManagement>  VisitorAccessManagements{ get; set; }
        public DbSet<Worker> Workers { get; set; }
    }
}
