using F1_Racing_System.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using F1_Racing_System.Models.Domain;
using AutoMapper;
using F1_Racing_System.Models.Dto;
using F1_Racing_System.Repositories;
using F1_Racing_System.Models.Dto.Team;

namespace F1_Racing_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITeamRepository _teamRepository;

        public TeamsController(IMapper mapper, ITeamRepository teamRepository)
        {
            _mapper = mapper;
            _teamRepository = teamRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamDto>>> GetTeams()
        {
            var teamDomainModels = await _teamRepository.GetTeamsAsync();

            var teamsDtos = _mapper.Map<List<TeamDto>>(teamDomainModels);

            return Ok(teamsDtos);

        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<TeamDto?>> GetTeam(int id)
        {
            var team = await _teamRepository.GetTeamByIdAsync(id);

            if (team == null)
                return NotFound();

            var teamDto = _mapper.Map<TeamDto>(team);

            return Ok(teamDto);
        }

        [HttpPost]
        public async Task<ActionResult<Team>> CreateTeam(CreateTeamDto createTeamDto)
        {
            var teamDomainModel = _mapper.Map<Team>(createTeamDto);
            var team = await _teamRepository.CreateTeamAsync(teamDomainModel);
            var teamDto = _mapper.Map<TeamDto>(team);

            return CreatedAtAction("GetTeam", new { teamId = team.Id }, team);
        }
    }
}