using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F1_Racing_System.Models.Dto.Standings;
using F1_Racing_System.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace F1_Racing_System.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StandingController : ControllerBase
    {
        private readonly IStandingsRepository _standingsRepository;

        public StandingController(IStandingsRepository standingsRepository)
        {
            _standingsRepository = standingsRepository;
        }

        [HttpGet("standing")]
        public async Task<ActionResult<IEnumerable<DriverStandingDto>>> GetDriverStandings()
        {
            var standings = await _standingsRepository.GetDriverStandingsAsync();
            return Ok(standings);
        }

        [HttpGet("standing/teams")]
        public async Task<ActionResult<IEnumerable<TeamStandingDto>>> GetTeamStandings()
        {
            var standings = await _standingsRepository.GetTeamStandingsAsync();
            return Ok(standings);
        }
    }
}