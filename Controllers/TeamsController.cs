using F1_Racing_System.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using F1_Racing_System.Models.Domain;
using AutoMapper;
using F1_Racing_System.Models.Dto;
using F1_Racing_System.Repositories;

namespace F1_Racing_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly TeamRepository _teamRepository;

        public TeamsController(IMapper mapper, TeamRepository teamRepository)
        {
            _mapper = mapper;
            _teamRepository = teamRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Team>>> GetTeams()
        {
            var teamDomainModels = await _teamRepository.GetTeamsAsync();

            var teamsDtos = _mapper.Map<List<TeamDto>>(teamDomainModels);

            return Ok(teamsDtos);
            
        }
            
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Team?>> GetTeam(int teamId)
        {
            var team = await _teamRepository.Gettem
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