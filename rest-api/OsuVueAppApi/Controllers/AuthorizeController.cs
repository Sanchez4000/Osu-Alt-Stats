using Microsoft.AspNetCore.Mvc;
using OsuVueAppApi.CommonServices.Interfaces;
using OsuVueAppApi.Requests;

namespace OsuVueAppApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthorizeController(IOsuApiService osuApi) : ControllerBase
    {
        private readonly IOsuApiService _osuApi = osuApi;

        [HttpPost]
        public async Task<string> GetOAuthToken([FromBody] GetOAuthTokenRequest request)
        {
            try
            {
                return await _osuApi.GetOAuthToken(request.AuthorizationCode);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        [HttpPost]
        public async Task Authorize([FromBody] AuthorizeRequest request)
        {
            await _osuApi.Authorize(request.AuthorizationCode);
        }
    }
}
