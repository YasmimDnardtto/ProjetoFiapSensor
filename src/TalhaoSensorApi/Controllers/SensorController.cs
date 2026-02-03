using Microsoft.AspNetCore.Mvc;
using TalhaoSensorApi.DTOs;
using TalhaoSensorApi.Services;
using System.Threading.Tasks;

namespace TalhaoSensorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SensorController : ControllerBase
    {
        private readonly SensorService _sensorService;

        public SensorController(SensorService sensorService)
        {
            _sensorService = sensorService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSensor([FromBody] SensorCreateDto sensorCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _sensorService.CreateSensor(sensorCreateDto);
            return CreatedAtAction(nameof(CreateSensor), new { id = sensorCreateDto.TalhaoId }, sensorCreateDto);
        }
    }
}