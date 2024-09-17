using Newtonsoft.Json;
using OsuVueAppApi.CommonServices.Interfaces;
using OsuVueAppApi.Data;
using OsuVueAppApi.Exceptions;
using OsuVueAppApi.Extensions;
using OsuVueAppApi.Models.Database;
using OsuVueAppApi.Models.Osu;
using OsuVueAppApi.OsuApiProviders;

namespace OsuVueAppApi.CommonServices.Implementations
{
    public class OsuApiService : IOsuApiService
    {
        private readonly int _clientId;
        private readonly string _clientSecret;
        private OsuOAuthData? _oAuthData = null;
        private readonly ApplicationDbContext _context;

        public UsersProvider Users
        {
            get
            {
                if (_oAuthData == null)
                    throw new NotAuthorizedException();

                return new UsersProvider(_oAuthData);
            }
        }

        public OsuApiService(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;

            var clientLoadTask = _context.OsuClients.GetDefault();
            clientLoadTask.Wait();

            var osuClient = clientLoadTask.Result ?? throw new NotAuthorizedException();
            _clientId = osuClient.ClientId;
            _clientSecret = osuClient.ClientSecret;

            var token = _context.AuthTokens.FirstOrDefault();

            if (token != null)
                _oAuthData = new OsuOAuthData(token);
        }

        public async Task Authorize(string authorizationCode)
        {
            var token = _context.AuthTokens.FirstOrDefault();

            if (token == null)
            {
                await DefaultAuthorization(authorizationCode);

                if (_oAuthData == null)
                    throw new Exception("Не удалось авторизоваться!");

                _context.AuthTokens.Add(new AuthToken(_oAuthData));
                await _context.SaveChangesAsync();
            }
            else
            {
                var timeNow = DateTime.Now;
                var deltaTime = timeNow - token.AuthTime;

                if (deltaTime.TotalSeconds >= token.ExpiresIn)
                {
                    await RefreshToken(token.RefreshToken);

                    if (_oAuthData == null)
                        throw new Exception("Не удалось авторизоваться!");

                    token.SetFromOsuOAuthData(_oAuthData);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    _oAuthData = new OsuOAuthData(token);
                }
            }
        }
        public async Task<bool> IsAuthorized()
        {
            await Task.Delay(100);
            throw new NotImplementedException();
        }

        private async Task DefaultAuthorization(string authorizationCode)
        {
            const string GRANT_TYPE = "authorization_code";
            await SetTokenFromOsuApi(
                $"client_id={_clientId}" +
                $"&client_secret={_clientSecret}" +
                $"&code={authorizationCode}" +
                $"&grant_type={GRANT_TYPE}");
        }
        private async Task SetTokenFromOsuApi(string data)
        {
            var client = new HttpClient();
            var msg = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://osu.ppy.sh/oauth/token"),
                Content = new StringContent(data)
            };
            msg.Headers.Add("Accept", "application/json");
            msg.Content.Headers.ContentType.MediaType = "application/x-www-form-urlencoded";

            var response = await client.SendAsync(msg);
            var json = await response.Content.ReadAsStringAsync();

            _oAuthData = JsonConvert.DeserializeObject<OsuOAuthData>(json);
        }
        private async Task RefreshToken(string refreshToken)
        {
            const string GRANT_TYPE = "refresh_token";
            await SetTokenFromOsuApi(
                $"client_id={_clientId}" +
                $"&client_secret={_clientSecret}" +
                $"&grant_type={GRANT_TYPE}" +
                $"&refresh_token={refreshToken}" +
                $"&scope=public+identify");
        }
    }
}
