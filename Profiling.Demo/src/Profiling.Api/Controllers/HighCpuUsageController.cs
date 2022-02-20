using Microsoft.AspNetCore.Mvc;

namespace Profiling.Api.Controllers
{
    [ApiController]
    [Route("high-cpu")]
    public class HighCpuUsageController : ControllerBase
    {

        private readonly ILogger<HighCpuUsageController> _logger;

        public HighCpuUsageController(ILogger<HighCpuUsageController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public void Get()
        {
           
        }
    }
}