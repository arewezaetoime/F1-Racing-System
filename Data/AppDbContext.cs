using F1_Racing_System.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace F1_Racing_System.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<DriverRace> DriverRaces { get; set; }

    }
}

// Example usage: