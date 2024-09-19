using Newtonsoft.Json;

namespace OsuVueAppApi.Models.Osu
{
    public class Page
    {
        [JsonProperty("html")]
        public string Html { get; set; }
        [JsonProperty("raw")]
        public string Raw { get; set; }
    }
}
