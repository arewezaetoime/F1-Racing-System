using F1_Racing_System.Data;
using F1_Racing_System.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace F1_Racing_System.Repositories
{
    public class DriverRepository : IDriverRepository
    {
        private readonly AppDbContext _context;

        public DriverRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Driver> CreateDriverAsync(Driver driver)
        {
            if (driver.TeamId.HasValue)
            {
                var teamDriverCount = await _context.Drivers
                    .CountAsync(d => d.TeamId == driver.TeamId);

                if (teamDriverCount >= 4)
                    return null;
            }
            await _context.Drivers.AddAsync(driver);
            await _context.SaveChangesAsync();

            return driver;
        }

        public async Task<Driver?> GetDriverByIdAsync(int id)
        {
            return await _context.Drivers.Include(t => t.Team).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Driver>> GetDriversAsync()
        {
            return await _context.Drivers.Include(t => t.Team).ToListAsync();
        }
    }
}
