namespace OsuVueAppApi.Models.Custom
{
    public class StandartResponse
    {
        public int Code { get; set; }
        public object? Data { get; set; }
        public ExceptionData? Exception { get; set; }
    }
}
