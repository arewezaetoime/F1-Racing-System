using F1_Racing_System.Data;
using F1_Racing_System.Models.Domain;
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

        async Task<Team> ITeamRepository.CreateTeamAsync(Team team)
        {
            await _context.Teams.AddAsync(team);
            await _context.SaveChangesAsync();
            return team;
        }

        async Task<Team?> ITeamRepository.GetTeamByIdAsync(int id)
        {
            return await _context.Teams.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Team>> GetTeamsAsync()
        {
            return await _context.Teams.ToListAsync();
        }

        internal async Task GetTeamById(int teamId)
        {
            throw new NotImplementedException();
        }
    }
}
