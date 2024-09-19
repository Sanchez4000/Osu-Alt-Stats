﻿using Newtonsoft.Json;

namespace OsuVueAppApi.Models.Osu
{
    public class Country
    {
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
