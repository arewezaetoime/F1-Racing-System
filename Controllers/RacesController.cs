using AutoMapper;
using F1_Racing_System.Models.Domain;
using F1_Racing_System.Models.Dto.Driver;
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
        private readonly IDriverRepository _driverRepository;

        public RacesController(IMapper mapper, IRaceRepository raceRepository, IDriverRepository driverRepository)
        {
            _mapper = mapper;
            _raceRepository = raceRepository;
            _driverRepository = driverRepository;
        }

        [HttpPost]
        public async Task<ActionResult<RaceDto>> CreateRaceAsync([FromBody] CreateRaceDto createRaceDto)
        {
            var race = await _raceRepository.CreateRaceAsync(createRaceDto);

            if (race == null)
                return BadRequest("Failed to create race.");

            var raceDto = _mapper.Map<RaceDto>(race);
            return CreatedAtAction("GetRaceByIdAsync", new { id = race.Id }, raceDto);
        }

        [HttpGet("{id}")]
        private async Task<ActionResult<RaceDto>> GetRaceByIdAsync(int id)
        {
            var race = await _raceRepository.GetRaceByIdAsync(id);

            if (race == null)
                return NotFound();

            return Ok(_mapper.Map<RaceDto>(race));
        }

        [HttpPost("{raceId}/enroll/{driverId}")]
        public async Task<ActionResult> EnrollDriverForRace(int raceId, int driverId)
        {
            var driverRace = await _raceRepository.EnrollDriverAsync(driverId, raceId);

            if (driverRace == null)
                return BadRequest(new
                {
                    message = "Unable to enroll driver. Either the driver/race doesn't exist, or the driver is already enrolled in this race."
                });

            return Ok(_mapper.Map<DriverRaceDto>(driverRace));
        }

        [HttpPost("result")]
        public async Task<ActionResult> PostRaceResults([FromBody] RaceResultsDto raceResultsDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var success = await _raceRepository.SaveRaceResultsAsync(raceResultsDto);

            if (!success)
                return NotFound("Race not found");

            return Ok("Race results saved successfully");
        }

    }
}
