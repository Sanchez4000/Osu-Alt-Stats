using Newtonsoft.Json;

namespace OsuVueAppApi.Models.Osu
{
    public class UserGroup : Group
    {
        [JsonProperty("playmodes")]
        public string[]? Playmodes { get; set; }
    }
}
