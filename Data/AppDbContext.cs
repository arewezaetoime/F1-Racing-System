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

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);

        //     modelBuilder.Entity<DriverRace>()
        //     .HasKey(dr => new { dr.DriverId, dr.RaceId });

        // modelBuilder.Entity<Team>()
        //     .HasMany(t => t.Drivers)
        //     .WithOne(d => d.Team)
        //     .HasForeignKey(d => d.TeamId);

        // modelBuilder.Entity<Driver>()
        //     .HasMany(d => d.DriverRaces)
        //     .WithOne(dr => dr.Driver)
        //     .HasForeignKey(dr => dr.DriverId);

        // modelBuilder.Entity<Race>()
        //     .HasMany(r => r.DriverRaces)
        //     .WithOne(dr => dr.Race)
        //     .HasForeignKey(dr => dr.RaceId);

        //     modelBuilder.Entity<Team>().HasData(
        //         new Team { Id = 1, Name = "Mercedes" },
        //         new Team { Id = 2, Name = "Red Bull" },
        //         new Team { Id = 3, Name = "Ferrari" },
        //         new Team { Id = 4, Name = "McLaren" },
        //         new Team { Id = 5, Name = "Aston Martin" },
        //         new Team { Id = 6, Name = "Alpine" },
        //         new Team { Id = 7, Name = "Alfa Romeo" },
        //         new Team { Id = 8, Name = "Haas" },
        //         new Team { Id = 9, Name = "Williams" }
        //     );

        //     modelBuilder.Entity<Driver>().HasData(
        //         new Driver { Id = 1, FirstName = "Lewis", LastName = "Hamilton", TeamId = 1 },
        //         new Driver { Id = 2, FirstName = "Max", LastName = "Verstappen", TeamId = 2 },
        //         new Driver { Id = 3, FirstName = "Charles", LastName = "Leclerc", TeamId = 3 },
        //         new Driver { Id = 4, FirstName = "Fernando", LastName = "Alonso", TeamId = 1 },
        //         new Driver { Id = 5, FirstName = "Lando", LastName = "Norris", TeamId = 4 },
        //         new Driver { Id = 6, FirstName = "Sebastian", LastName = "Vettel", TeamId = 5 },
        //         new Driver { Id = 7, FirstName = "Esteban", LastName = "Ocon", TeamId = 6 },
        //         new Driver { Id = 8, FirstName = "Valtteri", LastName = "Bottas", TeamId = 7 },
        //         new Driver { Id = 9, FirstName = "Mick", LastName = "Schumacher", TeamId = 8 },
        //         new Driver { Id = 10, FirstName = "George", LastName = "Russell", TeamId = 1 },
        //         new Driver { Id = 11, FirstName = "Nicholas", LastName = "Latifi", TeamId = 9 },
        //         new Driver { Id = 12, FirstName = "Pierre", LastName = "Gasly", TeamId = 6 }
        //     );

        //     modelBuilder.Entity<Race>().HasData(
        //         new Race { Id = 1, Name = "Monaco Grand Prix" },
        //         new Race { Id = 2, Name = "British Grand Prix" },
        //         new Race { Id = 3, Name = "Italian Grand Prix" },
        //         new Race { Id = 4, Name = "German Grand Prix" },
        //         new Race { Id = 5, Name = "Spanish Grand Prix" }
        //     );

        //     modelBuilder.Entity<DriverRace>().HasData(
        //         new DriverRace { DriverId = 1, RaceId = 1, Points = 25, FinishedFor = TimeSpan.FromMinutes(78) },
        //         new DriverRace { DriverId = 2, RaceId = 1, Points = 18, FinishedFor = TimeSpan.FromMinutes(79) },
        //         new DriverRace { DriverId = 3, RaceId = 1, Points = 15, FinishedFor = TimeSpan.FromMinutes(80) },
        //         new DriverRace { DriverId = 4, RaceId = 1, Points = 12, FinishedFor = TimeSpan.FromMinutes(81) },
        //         new DriverRace { DriverId = 5, RaceId = 1, Points = 10, FinishedFor = TimeSpan.FromMinutes(82) },
        //         new DriverRace { DriverId = 6, RaceId = 2, Points = 18, FinishedFor = TimeSpan.FromMinutes(90) },
        //         new DriverRace { DriverId = 7, RaceId = 2, Points = 15, FinishedFor = TimeSpan.FromMinutes(92) },
        //         new DriverRace { DriverId = 8, RaceId = 2, Points = 10, FinishedFor = TimeSpan.FromMinutes(93) },
        //         new DriverRace { DriverId = 9, RaceId = 2, Points = 8, FinishedFor = TimeSpan.FromMinutes(94) },
        //         new DriverRace { DriverId = 10, RaceId = 2, Points = 6, FinishedFor = TimeSpan.FromMinutes(95) },
        //         new DriverRace { DriverId = 1, RaceId = 3, Points = 25, FinishedFor = TimeSpan.FromMinutes(100) },
        //         new DriverRace { DriverId = 2, RaceId = 3, Points = 18, FinishedFor = TimeSpan.FromMinutes(102) },
        //         new DriverRace { DriverId = 3, RaceId = 3, Points = 15, FinishedFor = TimeSpan.FromMinutes(104) },
        //         new DriverRace { DriverId = 4, RaceId = 3, Points = 12, FinishedFor = TimeSpan.FromMinutes(106) }
        //     );
        // }

    }
}

