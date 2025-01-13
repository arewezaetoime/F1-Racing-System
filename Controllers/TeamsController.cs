using F1_Racing_System.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using F1_Racing_System.Models.Domain;

namespace F1_Racing_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TeamsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Team>>> GetTeams()
        {
            return await _context.Teams.Include(t => t.Drivers).ToListAsync();
        }

        [HttpGet("{teamId}")]
        public async Task<ActionResult<Team>> GetTeam(int teamId)
        {
            var team = await _context.Teams
                .Include(t => t.Drivers)
                .FirstOrDefaultAsync(t => t.Id == teamId);

            if (team == null)
                return NotFound();

            return team;
        }

        [HttpPost]
        public async Task<ActionResult<Team>> CreateTeam(Team team)
        {
            _context.Teams.Add(team);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTeam), new { teamId = team.Id }, team);
        }
    }
}