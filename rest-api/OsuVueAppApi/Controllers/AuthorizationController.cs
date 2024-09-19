using Microsoft.AspNetCore.Mvc;
using OsuVueAppApi.CommonServices.Interfaces;
using OsuVueAppApi.Data;
using OsuVueAppApi.Extensions;
using OsuVueAppApi.Models.Custom;
using OsuVueAppApi.Models.Osu;
using OsuVueAppApi.Requests;

namespace OsuVueAppApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthorizationController(ApplicationDbContext context, IOsuApiService osuApi) : ControllerBase
    {
        private readonly IOsuApiService _osuApi = osuApi;
        private readonly ApplicationDbContext _context = context;

        [HttpPost]
        public async Task Authorize([FromBody] AuthorizeRequest request)
        {
            await _osuApi.Authorize(request.AuthorizationCode);
        }
        [HttpGet]
        public async Task<UserbarData> GetUserbarData()
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        public async Task<UserExtended> GetMe()
        {
            return await _osuApi.Users.GetMe();
        }
        [HttpGet]
        public async Task<string?> GetAuthLink()
        {
            var client = await _context.OsuClients.GetDefault();

            if (client == null)
                return null;

            const string BASE_URL = "https://osu.ppy.sh/oauth/authorize";
            return $"{BASE_URL}?client_id={client.ClientId}&response_type=code&scope=public+identify";
        }
    }
}
