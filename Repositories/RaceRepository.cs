using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using F1_Racing_System.Data;
using F1_Racing_System.Models.Domain;
using F1_Racing_System.Models.Dto.Race;
using Microsoft.EntityFrameworkCore;

namespace F1_Racing_System.Repositories
{
    public class RaceRepository : IRaceRepository
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public RaceRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Race> CreateRaceAsync(CreateRaceDto raceDto)
        {
            var race = _mapper.Map<Race>(raceDto);
            await _context.Races.AddAsync(race);
            await _context.SaveChangesAsync();
            return race;
        }

        public async Task<Race?> GetRaceByIdAsync(int id)
        {
            return await _context.Races
                .Include(r => r.DriverRaces)
                .FirstOrDefaultAsync(x => x.Id == id);
        }


        public async Task<DriverRace> EnrollDriverAsync(int driverId, int raceId)
        {
            var driver = await _context.Drivers.FindAsync(driverId);
            var race = await _context.Races.FindAsync(raceId);

            if (race == null || driver == null)
                return null;

            var existingEnrollment = await _context.DriverRaces
                .FirstOrDefaultAsync(dr => dr.DriverId == driverId && dr.RaceId == raceId);

            if (existingEnrollment != null)
                return null;

            var driverRace = new DriverRace
            {
                DriverId = driverId,
                RaceId = raceId,
                Points = 0
            };

            await _context.DriverRaces.AddAsync(driverRace);
            await _context.SaveChangesAsync();
            return driverRace;
        }

        async Task<List<Driver>> IRaceRepository.GetFinalResultsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveRaceResultsAsync(RaceResultsDto raceResultsDto)
        {
            var race = await _context.Races
                .Include(r => r.DriverRaces)
                .FirstOrDefaultAsync(r => r.Id == raceResultsDto.RaceId);

            if (race == null)
                return false;

            var sortedResults = raceResultsDto.Results
                .OrderBy(r => r.FinishedFor)
                .ToList();

            for (int i = 0; i < sortedResults.Count; i++)
            {
                var result = sortedResults[i];
                var position = i + 1;
                var points = (short)(20 - position);

                if (points < 0) points = 0; 

                var driverRace = await _context.DriverRaces
                    .FirstOrDefaultAsync(dr =>
                        dr.RaceId == raceResultsDto.RaceId &&
                        dr.DriverId == result.DriverId);

                if (driverRace == null)
                {
                    driverRace = new DriverRace
                    {
                        DriverId = result.DriverId,
                        RaceId = raceResultsDto.RaceId,
                        Points = points,
                        FinishedFor = result.FinishedFor
                    };
                    await _context.DriverRaces.AddAsync(driverRace);
                }
                else
                {
                    driverRace.FinishedFor = result.FinishedFor;
                    driverRace.Points = points;
                }
            }

            await _context.SaveChangesAsync();
            return true;
        }
    }
}

