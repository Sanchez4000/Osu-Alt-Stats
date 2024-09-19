using Newtonsoft.Json;

namespace OsuVueAppApi.Models.Osu
{
    public class User
    {
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }
        [JsonProperty("default_group")]
        public string? DefaultGroup { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("is_active")]
        public bool IsActive { get; set; }
        [JsonProperty("is_bot")]
        public bool IsBot { get; set; }
        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }
        [JsonProperty("is_online")]
        public bool IsOnline { get; set; }
        [JsonProperty("is_supporter")]
        public bool IsSupporter { get; set; }
        [JsonProperty("last_visit")]
        public DateTime? LastVisit { get; set; }
        [JsonProperty("pm_friends_only")]
        public bool PmFriendsOnly { get; set; }
        [JsonProperty("profile_colour")]
        public string? ProfileColour { get; set; }
        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("account_history")]
        public UserAccountHistory[] AccountHistory { get; set; }
        [JsonProperty("active_tournament_banners")]
        public ProfileBanner[] ActiveTournamentBanners { get; set; }
        [JsonProperty("beatmap_playcounts_count")]
        public int BeatmapPlaycountsCount { get; set; }
        [JsonProperty("favourite_beatmapset_count")]
        public int FavouriteBeatmapsetCount { get; set; }
        [JsonProperty("follow_user_mapping")]
        public int[] FollowUserMapping { get; set; }
        [JsonProperty("follower_count")]
        public int FollowerCount { get; set; }
        [JsonProperty("graveyard_beatmapset_count")]
        public int GraveyardBeatmapsetCount { get; set; }
        [JsonProperty("groups")]
        public UserGroup[] Groups { get; set; }
        [JsonProperty("guest_beatmapset_count")]
        public int GuestBeatmapsetCount { get; set; }
        [JsonProperty("is_restricted")]
        public bool? IsRestricted { get; set; }
        [JsonProperty("kudosu")]
        public Kudosu Kudosu { get; set; }
        [JsonProperty("loved_beatmapset_count")]
        public int LovedBeatmapsetCount { get; set; }
        [JsonProperty("mapping_follower_count")]
        public int MappingFollowerCount { get; set; }
        [JsonProperty("monthly_playcounts")]
        public MonthlyPlaycount[] MonthlyPlaycounts { get; set; }
        [JsonProperty("page")]
        public Page Page { get; set; }
        [JsonProperty("pending_beatmapset_count")]
        public int PendingPeatmapsetCount { get; set; }
        [JsonProperty("previous_usernames")]
        public string[] PreviousUsernames { get; set; }
        [JsonProperty("rank_highest")]
        public RankHighest? RankHighest { get; set; }
        [JsonProperty("rank_history")]
        public RankHistory? RankHistory { get; set; }
        [JsonProperty("ranked_beatmapset_count")]
        public int RankedBeatmapsetCount { get; set; }
        [JsonProperty("replays_watched_counts")]
        public MonthlyPlaycount[] ReplaysWatchedCounts { get; set; }
        [JsonProperty("scores_best_count")]
        public int ScoresBestCount { get; set; }
        [JsonProperty("scores_first_count")]
        public int ScoresFirstCount { get; set; }
        [JsonProperty("scores_recent_count")]
        public int ScoresRecentCount { get; set; }
        [JsonProperty("session_verified")]
        public bool SessionVerified { get; set; }
        [JsonProperty("statistics")]
        public UserStatistics Statistics { get; set; }
        [JsonProperty("statistics_rulesets")]
        public UserStatisticsRulesets StatisticsRulesets { get; set; }
        [JsonProperty("support_level")]
        public int SupportLevel { get; set; }
        [JsonProperty("unread_pm_count")]
        public int UnreadPmCount { get; set; }
        [JsonProperty("user_achievements")]
        public UserAchievement[] UserAchievements { get; set; }
    }
}
