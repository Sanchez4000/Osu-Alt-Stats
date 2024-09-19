using Newtonsoft.Json;

namespace OsuVueAppApi.Models.Osu
{ 
    public class GradeCounts
    {
        [JsonProperty("a")]
        public int A { get; set; }

        [JsonProperty("s")]
        public int S { get; set; }

        [JsonProperty("sh")]
        public int Sh { get; set; }

        [JsonProperty("ss")]
        public int Ss { get; set; }

        [JsonProperty("ssh")]
        public int Ssh { get; set; }
    }

}