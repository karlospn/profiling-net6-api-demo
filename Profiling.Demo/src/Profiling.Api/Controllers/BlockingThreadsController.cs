using Microsoft.AspNetCore.Mvc;

namespace Profiling.Api.Controllers
{
    [ApiController]
    [Route("blocking-threads")]
    public class BlockingThreadsController : ControllerBase
    {

        private readonly ILogger<BlockingThreadsController> _logger;

        public BlockingThreadsController(ILogger<BlockingThreadsController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public void Get()
        {
           
        }
    }
}