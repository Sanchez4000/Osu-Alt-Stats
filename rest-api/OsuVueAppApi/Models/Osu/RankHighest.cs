using Newtonsoft.Json;

namespace OsuVueAppApi.Models.Osu
{
    public class RankHighest
    {
        [JsonProperty("rank")]
        public int Rank { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
