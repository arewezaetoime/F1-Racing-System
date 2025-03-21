using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F1_Racing_System.Models.Dto.Standings;

namespace F1_Racing_System.Repositories
{
    public interface IStandingsRepository
    {
        Task<List<DriverStandingDto>> GetDriverStandingsAsync();
        Task<List<TeamStandingDto>> GetTeamStandingsAsync();
    }
}