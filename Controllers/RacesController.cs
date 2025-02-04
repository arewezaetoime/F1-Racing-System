using AutoMapper;
using F1_Racing_System.Models.Domain;
using F1_Racing_System.Models.Dto.Race;
using F1_Racing_System.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace F1_Racing_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RacesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IRaceRepository _raceRepository;

        public RacesController(IMapper mapper, IRaceRepository raceRepository)
        {
            _mapper = mapper;
            _raceRepository = raceRepository;
        }

        [HttpPost]
        public async Task<ActionResult<RaceDto>> CreateRaceAsync([FromBody] CreateRaceDto createRaceDto)
        {
            var race = await _raceRepository.CreateRaceAsync(createRaceDto);

            if (race == null)
            {
                return BadRequest("Failed to create race.");
            }

            var raceDto = _mapper.Map<RaceDto>(race);
            return CreatedAtAction(nameof(GetRaceByIdAsync), new { id = race.Id }, raceDto);
        }

        [HttpGet("{id}")]
        private async Task<ActionResult<RaceDto>> GetRaceByIdAsync(int id)
        {
            var race = await _raceRepository.GetRaceByIdAsync(id);

            if (race == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<RaceDto>(race));
        }

    }
}
