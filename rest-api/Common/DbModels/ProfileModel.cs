namespace Common.DbModels
{
    public class ProfileModel
    {
        public int Id { get; set; } = 0;
        public required string Name { get; set; }
        public required bool IsActive { get; set; }
        public string ApplicationId { get; set; } = string.Empty;
        public string ApplicationSecret { get; set; } = string.Empty;
    }
}
