using AutoMapper;
using F1_Racing_System.Models.Dto.Driver;
using F1_Racing_System.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using F1_Racing_System.Models.Domain;

namespace F1_Racing_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IDriverRepository _driverRepository;

        public DriversController(IMapper mapper, IDriverRepository driverRepository)
        {
            _mapper = mapper;
            _driverRepository = driverRepository;
        }

        // GET: api/Drivers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DriverDto>>> GetDrivers()
        {
            var driverDomainModels = await _driverRepository.GetDriversAsync();
            var driverDtos = _mapper.Map<List<DriverDto>>(driverDomainModels);

            return Ok(driverDtos);
        }

        // GET: api/Drivers/GetDriverByIdAsync
        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetDriverByIdAsync([FromRoute] int id)
        {
            var driverDomainModel = await _driverRepository.GetDriverByIdAsync(id);

            if (driverDomainModel == null)
                return NotFound();

            var driverDto = _mapper.Map<DriverDto>(driverDomainModel);
            return Ok(driverDto);
        }

        // POST: api/Drivers/CreateDriver
        [HttpPost]
        public async Task<ActionResult> CreateDriverAsync([FromBody] CreateDriverDto createDriverDto)
        {
            var driverDomainModel = _mapper.Map<Driver>(createDriverDto);
            var driver = await _driverRepository.CreateDriverAsync(driverDomainModel);

            if (driver == null || driver.Id == 0)
            {
                return BadRequest("ID is not valid or there is no place in the team 4/4 drivers.");
            }

            var driverDto = _mapper.Map<DriverDto>(driver);
            // var url = Url.Action(nameof(GetDriverByIdAsync), new { id = driver.Id });
            // Console.WriteLine($"Generated URL: {url}");

            // Correctly specify the route parameter for the CreatedAtAction method
            return CreatedAtAction("GetDriverById", new { id = driver.Id }, driverDto);
        }
    }
}
