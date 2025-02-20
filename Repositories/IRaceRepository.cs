using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F1_Racing_System.Models.Domain;
using F1_Racing_System.Models.Dto.Race;

namespace F1_Racing_System.Repositories
{
    public interface IRaceRepository
    {
        Task<Race> CreateRaceAsync(CreateRaceDto createRaceDto);
        Task<Race?> GetRaceByIdAsync(int id);
        Task<DriverRace> EnrollDriverAsync(int driverId, int raceId);
        Task<List<Driver>> GetFinalResultsAsync();
    }
}