using Microsoft.AspNetCore.Mvc;
using OsuVueAppApi.CommonServices.Interfaces;
using OsuVueAppApi.Requests;

namespace OsuVueAppApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController(IOsuApiService osuApi) : ControllerBase
    {
        private readonly IOsuApiService _osuApi = osuApi;

        [HttpPost]
        public async Task<string> GetUser([FromBody] GetUserRequest request)
        {
            return await _osuApi.Users.GetUser(request.Id, request.Mode);
        }
    }
}
