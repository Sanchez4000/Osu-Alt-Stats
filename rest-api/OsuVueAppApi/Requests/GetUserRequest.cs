namespace OsuVueAppApi.Requests
{
    public class GetUserRequest
    {
        public int Id { get; set; } = 0;
        public string Mode { get; set; } = "osu";
    }
}
