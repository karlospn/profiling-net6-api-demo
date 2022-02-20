using Microsoft.AspNetCore.Mvc;

namespace Profiling.Api.Controllers
{
    [ApiController]
    [Route("memory-leak")]
    public class MemoryLeakController : ControllerBase
    {

        private readonly ILogger<MemoryLeakController> _logger;

        public MemoryLeakController(ILogger<MemoryLeakController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public void Get()
        {
           
        }
    }
}