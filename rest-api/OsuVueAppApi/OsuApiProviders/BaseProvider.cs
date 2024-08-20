using Newtonsoft.Json;
using OsuVueAppApi.Models.Osu;

namespace OsuVueAppApi.OsuApiProviders
{
    public abstract class BaseProvider(OsuOAuthData oAuthData)
    {
        private readonly OsuOAuthData _oAuthData = oAuthData;
        private const string _baseUrl = "https://osu.ppy.sh/api/v2";

        protected string BuildUrl(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path));

            if (path.First() != '/')
                return $"{_baseUrl}/{path}";
            else
                return $"{_baseUrl}{path}";
        }
        protected async Task<string> SendRequest(string url, HttpMethod method, HttpContent? content = null)
        {
            var client = new HttpClient();
            var msg = GetMessage(url, method, content);
            var json = JsonConvert.SerializeObject(_oAuthData);
            msg.Headers.Add("Authorization", $"Bearer {_oAuthData.AccessToken}");
            var response = await client.SendAsync(msg);
            return await response.Content.ReadAsStringAsync();
        }
        protected abstract HttpRequestMessage GetMessage(string url, HttpMethod method, HttpContent? content = null);
    }
}
