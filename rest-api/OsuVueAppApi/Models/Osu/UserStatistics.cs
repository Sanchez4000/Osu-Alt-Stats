using Newtonsoft.Json;

namespace OsuVueAppApi.Models.Osu
{ 
    public class UserStatistics
    {
        [JsonProperty("count_100")]
        public int Count100 { get; set; }

        [JsonProperty("count_300")]
        public int Count300 { get; set; }

        [JsonProperty("count_50")]
        public int Count50 { get; set; }

        [JsonProperty("count_miss")]
        public int CountMiss { get; set; }

        [JsonProperty("grade_counts")]
        public GradeCounts GradeCounts { get; set; }

        [JsonProperty("hit_accuracy")]
        public double HitAccuracy { get; set; }

        [JsonProperty("is_ranked")]
        public bool IsRanked { get; set; }

        [JsonProperty("level")]
        public Level Level { get; set; }

        [JsonProperty("maximum_combo")]
        public int MaximumCombo { get; set; }

        [JsonProperty("play_count")]
        public int PlayCount { get; set; }

        [JsonProperty("play_time")]
        public object PlayTime { get; set; }

        [JsonProperty("pp")]
        public float Pp { get; set; }

        [JsonProperty("global_rank")]
        public int? GlobalRank { get; set; }

        [JsonProperty("ranked_score")]
        public long RankedScore { get; set; }

        [JsonProperty("replays_watched_by_others")]
        public int ReplaysWatchedByOthers { get; set; }

        [JsonProperty("total_hits")]
        public int TotalHits { get; set; }

        [JsonProperty("total_score")]
        public long TotalScore { get; set; }
    }

}