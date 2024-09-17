using Microsoft.EntityFrameworkCore;

namespace OsuVueAppApi.Models.Database
{
    [PrimaryKey(nameof(Id))]
    public class OsuClient
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string ClientSecret { get; set; } = string.Empty;
    }
}
