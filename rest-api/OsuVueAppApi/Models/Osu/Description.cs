using Newtonsoft.Json;

namespace OsuVueAppApi.Models.Osu
{
    public class Description
    {
        [JsonProperty("html")]
        public string Html { get; set; }
        [JsonProperty("markdown")]
        public string Markdown { get; set; }
    }
}
