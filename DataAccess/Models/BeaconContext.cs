using Microsoft.EntityFrameworkCore;


namespace DataAccess.Models
{
    public class BeaconContext: DbContext
    {


        public BeaconContext (DbContextOptions<BeaconContext> options) : base(options)
        {

        }



        public DbSet<BeaconInfo> beaconInfos { get; set; }
        public DbSet<SensorInfo> sensorInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BeaconInfo>().ToTable("BeaconInfo");
            modelBuilder.Entity<SensorInfo>().ToTable("SensorInfo");
        }

    }
}
