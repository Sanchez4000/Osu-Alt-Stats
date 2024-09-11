using Microsoft.AspNetCore.Mvc;
using OsuVueAppApi.CommonServices.Interfaces;
using OsuVueAppApi.Requests;

namespace OsuVueAppApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthorizationController(IConfiguration configuration, IOsuApiService osuApi) : ControllerBase
    {
        private readonly IOsuApiService _osuApi = osuApi;
        private readonly int _clientId = configuration.GetValue<int>("ClientId");

        [HttpPost]
        public async Task Authorize([FromBody] AuthorizeRequest request)
        {
            await _osuApi.Authorize(request.AuthorizationCode);
        }
        [HttpGet]
        public async Task<int> GetClientId()
        {
            return _clientId;
        }
    }
}
