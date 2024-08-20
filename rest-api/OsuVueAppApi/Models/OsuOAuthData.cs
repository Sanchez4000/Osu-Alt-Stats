using Newtonsoft.Json;

namespace OsuVueAppApi.Models
{
    public class OsuOAuthData
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; init; } = string.Empty;
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; init; } = 0;
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; init; } = string.Empty;
        [JsonProperty("token_type")]
        public string TokenType { get; init; } = string.Empty;
    }
}
