using Newtonsoft.Json;

namespace OsuVueAppApi.Models.Osu
{
    public class MonthlyPlaycount
    {
        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
