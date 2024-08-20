namespace OsuVueAppApi.Requests
{
    public class GetOAuthTokenRequest
    {
        public string AuthorizationCode { get; set; } = string.Empty;
    }
}
