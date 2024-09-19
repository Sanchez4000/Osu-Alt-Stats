using Newtonsoft.Json;

namespace OsuVueAppApi.Models.Osu
{
    public class UserAccountHistory
    {
        [JsonProperty("description")]
        public string? Description { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("length")]
        public int Length { get; set; }
        [JsonProperty("permanent")]
        public bool Permanent { get; set; }
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
