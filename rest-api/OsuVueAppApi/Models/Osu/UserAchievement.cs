using Newtonsoft.Json;

namespace OsuVueAppApi.Models.Osu
{
    public class UserAchievement
    {
        [JsonProperty("achieved_at")]
        public DateTime AchievedAt { get; set; }
        [JsonProperty("achievement_id")]
        public int AchievementId { get; set; }
    }
}
