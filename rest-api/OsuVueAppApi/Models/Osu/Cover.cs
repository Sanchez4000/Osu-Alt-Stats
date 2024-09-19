using Newtonsoft.Json;

namespace OsuVueAppApi.Models.Osu
{
    public class Cover
    {
        [JsonProperty("custom_url")]
        public string? CustomUrl { get; set; }
        [JsonProperty("url")]
        public string? Url { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
