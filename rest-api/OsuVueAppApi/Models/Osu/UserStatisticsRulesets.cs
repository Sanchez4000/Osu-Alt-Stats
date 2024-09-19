using Newtonsoft.Json;

namespace OsuVueAppApi.Models.Osu
{
    public class UserStatisticsRulesets
    {
        [JsonProperty("osu")]
        public UserStatistics Osu { get; set; }
        [JsonProperty("taiko")]
        public UserStatistics Taiko { get; set; }
        [JsonProperty("fruits")]
        public UserStatistics Fruits { get; set; }
        [JsonProperty("mania")]
        public UserStatistics Mania { get; set; }
    }
}
