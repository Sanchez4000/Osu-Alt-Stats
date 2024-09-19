using Newtonsoft.Json;

namespace OsuVueAppApi.Models.Osu
{ 
    public class Level
    {
        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }
    }

}