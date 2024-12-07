using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ELK_Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult ValueRange()
        {
            _logger.LogInformation("Getting values");

            return Ok(new string[] { "value1", "value2" });
        }

        
    }
}
