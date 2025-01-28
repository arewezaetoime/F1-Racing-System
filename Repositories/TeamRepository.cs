using F1_Racing_System.Data;
using F1_Racing_System.Models.Domain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace F1_Racing_System.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly AppDbContext _context;

        public TeamRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Team> CreateTeamAsync(Team team)
        {
            await _context.Teams.AddAsync(team);
            await _context.SaveChangesAsync();
            return team;
        }

        async Task<Team?> ITeamRepository.GetTeamByIdAsync(int id)
        {
            var team = await _context.Teams
            .Include(d => d.Drivers)
            .FirstOrDefaultAsync(x => x.Id == id);

            return team;
        }

        public async Task<List<Team>> GetTeamsAsync()
        {
            return await _context.Teams
            .Include(t => t.Drivers)
            .ToListAsync();
        }
    }
}
