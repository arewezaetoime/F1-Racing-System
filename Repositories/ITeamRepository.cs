using F1_Racing_System.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace F1_Racing_System.Repositories
{
    public interface ITeamRepository
    {
        Task<List<Team>> GetTeamsAsync();
        Task<Team?> GetTeamByIdAsync(int id);
        Task<Team> CreateTeamAsync(Team team);

    }
}
