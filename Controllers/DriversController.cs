using AutoMapper;
using F1_Racing_System.Models.Dto.Driver;
using F1_Racing_System.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using F1_Racing_System.Models.Domain;
using Serilog;

namespace F1_Racing_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IDriverRepository _driverRepository;
        private readonly ILogger<DriversController> _logger;

        public DriversController(IMapper mapper, IDriverRepository driverRepository, ILogger<DriversController> logger)
        {
            _mapper = mapper;
            _driverRepository = driverRepository;
            _logger = logger;
        }

        // GET: api/Drivers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DriverDto>>> GetDrivers()
        {
            try
            {
                _logger.LogInformation("Fetching all drivers");
                var driverDomainModels = await _driverRepository.GetDriversAsync();
                var driverDtos = _mapper.Map<List<DriverDto>>(driverDomainModels);
                return Ok(driverDtos);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching drivers");
                return StatusCode(500, "Internal Server Error");
            }
        }

        // GET: api/Drivers/{id}
        [HttpGet("{id:int}", Name = "GetDriverByIdRoute")]
        public async Task<ActionResult> GetDriverByIdAsync([FromRoute] int id)
        {
            try
            {
                _logger.LogInformation("Fetching driver with ID: {Id}", id);
                var driverDomainModel = await _driverRepository.GetDriverByIdAsync(id);
                
                if (driverDomainModel == null)
                {
                    _logger.LogWarning("Driver with ID {Id} not found", id);
                    return NotFound();
                }
                
                var driverDto = _mapper.Map<DriverDto>(driverDomainModel);
                return Ok(driverDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching driver with ID: {Id}", id);
                return StatusCode(500, "Internal Server Error");
            }
        }

        // POST: api/Drivers
        [HttpPost]
        public async Task<ActionResult> CreateDriverAsync([FromBody] CreateDriverDto createDriverDto)
        {
            try
            {
                _logger.LogInformation("Creating a new driver");
                var driverDomainModel = _mapper.Map<Driver>(createDriverDto);
                var driver = await _driverRepository.CreateDriverAsync(driverDomainModel);
                
                if (driver == null || driver.Id == 0)
                {
                    _logger.LogWarning("Failed to create driver - Invalid ID or team limit reached");
                    return BadRequest("ID is not valid or there is no place in the team (4/4 drivers). ");
                }
                
                var driverDto = _mapper.Map<DriverDto>(driver);
                return CreatedAtRoute("GetDriverByIdRoute", new { id = driver.Id }, driverDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a driver");
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
