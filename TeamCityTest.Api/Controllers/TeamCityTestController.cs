using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TeamCityTest.Api.Controllers
{
    
    [ApiController]
    [Route("[controller]/[action]")]
    public class TeamCityTestController : ControllerBase
    {
        public TeamCityTestController()
        {
             
        }

        [HttpGet]
        public async Task<IActionResult> Ping()
        {
            return Ok("Api working on Docker!");
        }

    }
}
