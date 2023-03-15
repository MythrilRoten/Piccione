using Piccione;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Threading.Tasks;


namespace Piccione.Controllers
{
    [Route("api/v1/test")]
    [ApiController]
    public class TestController: ControllerBase
    {

        private IWebHostEnvironment Environment;
        private readonly ILogger<TestController> _logger;
        private readonly TestController _dbContext;

        public TestController(ILogger<TestController> logger, IWebHostEnvironment _environment, TestController dbContext)
        {
            _logger = logger;
            Environment = _environment;
            _dbContext = dbContext;
        }

        [HttpGet("{objId}")]
        public ActionResult TestMethod(string objId)
        {
            try
            {
                // BodyMethod

                return Ok(objId);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
