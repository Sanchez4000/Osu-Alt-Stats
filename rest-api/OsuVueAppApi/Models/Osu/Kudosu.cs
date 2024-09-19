using Newtonsoft.Json;

namespace OsuVueAppApi.Models.Osu
{
    public class Kudosu
    {
        [JsonProperty("available")]
        public int Available { get; set; }
        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
