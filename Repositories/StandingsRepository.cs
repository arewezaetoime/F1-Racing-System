using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F1_Racing_System.Data;
using F1_Racing_System.Models.Dto.Standings;
using Microsoft.EntityFrameworkCore;

namespace F1_Racing_System.Repositories
{
    public class StandingsRepository : IStandingsRepository
    {
        private readonly AppDbContext _context;

        public StandingsRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<DriverStandingDto>> GetDriverStandingsAsync()
        {
            var driverStandings = await _context.Drivers
                .Include(d => d.Team)
                .Include(d => d.DriverRaces)
                .Select(d => new DriverStandingDto
                {
                    DriverName = d.FirstName + " " + d.LastName,
                    TeamName = d.Team.Name,
                    TotalPoints = d.DriverRaces.Sum(dr => (int)dr.Points)
                })
                .OrderByDescending(s => s.TotalPoints)
                .ToListAsync();

            if (driverStandings is null) return null;

            return driverStandings;
        }

        public async Task<List<TeamStandingDto>> GetTeamStandingsAsync()
        {
            var teamStandings = await _context.Teams
                .Include(t => t.Drivers)
                .ThenInclude(d => d.DriverRaces)
                .Select(t => new TeamStandingDto
                {
                    TeamName = t.Name,
                    TotalPoints = t.Drivers.SelectMany(d => d.DriverRaces).Sum(dr => (int)dr.Points)
                })
                .OrderByDescending(s => s.TotalPoints)
                .ToListAsync();

            if (teamStandings is null) return null;

            return teamStandings;
        }
    }
}