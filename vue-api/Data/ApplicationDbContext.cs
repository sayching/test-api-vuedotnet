using System.Data.Entity;
using WeightTrackerOkta.Models;

namespace WeightTrackerOkta.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("OktaConnectionString")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<WeightMeasurement> WeightMeasurements { get; set; }
    }
}