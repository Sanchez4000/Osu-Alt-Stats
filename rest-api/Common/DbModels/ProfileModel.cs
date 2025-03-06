namespace Common.DbModels
{
    public class ProfileModel
    {
        public int Id { get; set; } = 0;
        public required string Name { get; set; }
        public required bool IsActive { get; set; }
    }
}
