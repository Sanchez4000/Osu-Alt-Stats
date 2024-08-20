namespace OsuVueAppApi.Utilities
{
    public static class HttpClientHelper
    {
        public static HttpRequestMessage GetOsuApiMessage(string url, HttpMethod method, HttpContent? content)
        {
            var msg = new HttpRequestMessage
            {
                RequestUri = new Uri(url),
                Method = method,
                Content = content
            };
            msg.Headers.Add("Accept", "application/json");
            msg.Content.Headers.ContentType.MediaType = "application/x-www-form-urlencoded";

            return msg;
        }
    }
}
