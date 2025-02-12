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


        async Task<DriverRace> IRaceRepository.EnrollDriverAsync(int id)
        {
            var driver = await _context.Drivers.FindAsync(id);
            var race = await _context.Races.FindAsync(id);

            if (driver == null || race == null)
                return null;

            var driverRace = new DriverRace
            {
                DriverId = driver.Id,
                RaceId = race.Id,
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
    }
}

