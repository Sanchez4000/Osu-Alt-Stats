using Newtonsoft.Json;

namespace OsuVueAppApi.Models.Osu
{
    public class RankHistory
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
        [JsonProperty("data")]
        public int[] Data { get; set; }
    }
}
