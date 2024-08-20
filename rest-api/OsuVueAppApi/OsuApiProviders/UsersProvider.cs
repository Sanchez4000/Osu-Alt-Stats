using OsuVueAppApi.Models.Osu;

namespace OsuVueAppApi.OsuApiProviders
{
    public sealed class UsersProvider(OsuOAuthData oAuthData) : BaseProvider(oAuthData)
    {
        public async Task<string> GetUser(int id, string mode = "osu")
        {
            var json = await SendRequest(BuildUrl($"/users/{id}/{mode}"), HttpMethod.Get);
            return json;
        }

        protected override HttpRequestMessage GetMessage(string url, HttpMethod method, HttpContent? content)
        {
            var msg = new HttpRequestMessage
            {
                RequestUri = new Uri(url),
                Method = method,
                Content = content ?? new StringContent("")
            };

            msg.Headers.Add("Accept", "application/json");
            msg.Content.Headers.ContentType.MediaType = "application/json";

            return msg;
        }
    }
}
