using Microsoft.AspNetCore.Mvc;

namespace OsuWebApp.RestApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Test()
        {
            return Ok("Test successful!");
        }
    }
}
