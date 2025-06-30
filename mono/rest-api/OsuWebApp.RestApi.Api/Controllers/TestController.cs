using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OsuWebApp.RestApi.Data;

namespace OsuWebApp.RestApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController(ApplicationDbContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Test()
        {
            var data = await context.TestData.FirstAsync(x => x.Id == 1);

            return Ok($"Id: {data.Id} Data: {data.SomeData}");
        }
    }
}
