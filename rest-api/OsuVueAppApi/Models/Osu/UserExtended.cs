using Newtonsoft.Json;

namespace OsuVueAppApi.Models.Osu
{
    public class UserExtended : User
    {
        [JsonProperty("cover_url")]
        public string CoverUrl { get; set; }
        [JsonProperty("discord")]
        public string? Discord { get; set; }
        [JsonProperty("has_supported")]
        public bool HasSupported { get; set; }
        [JsonProperty("interests")]
        public string? Interests { get; set; }
        [JsonProperty("join_date")]
        public DateTime JoinDate { get; set; }
        [JsonProperty("location")]
        public string? Location { get; set; }
        [JsonProperty("max_blocks")]
        public int MaxBlocks { get; set; }
        [JsonProperty("max_friends")]
        public int MaxFriends { get; set; }
        [JsonProperty("occupation")]
        public string? Occupation { get; set; }
        [JsonProperty("playmode")]
        public string Playmode { get; set; }
        [JsonProperty("playstyle")]
        public string[] Playstyle { get; set; }
        [JsonProperty("post_count")]
        public int PostCount { get; set; }
        [JsonProperty("profile_hue")]
        public int? ProfileHue { get; set; }
        [JsonProperty("profile_order")]
        public string[] ProfileOrder { get; set; }
        [JsonProperty("title")]
        public string? Title { get; set; }
        [JsonProperty("title_url")]
        public string? TitleUrl { get; set; }
        [JsonProperty("twitter")]
        public string? Twitter { get; set; }
        [JsonProperty("website")]
        public string? Website { get; set; }

        [JsonProperty("country")]
        public Country Country { get; set; }
        [JsonProperty("cover")]
        public Cover Cover { get; set; }
        [JsonProperty("is_restricted")]
        public bool? IsRestricted { get; set; }
    }
}
