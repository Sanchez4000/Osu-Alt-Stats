using Microsoft.EntityFrameworkCore;

namespace OsuVueAppApi.Models.Database
{
    [PrimaryKey(nameof(Id))]
    public class AuthToken
    {
        public int Id { get; set; } = 0;
        public string AccessToken { get; set; } = string.Empty;
        public int ExpiresIn { get; set; } = 0;
        public string RefreshToken { get; set; } = string.Empty;
        public string TokenType { get; set; } = string.Empty;
        public DateTime AuthTime { get; set; } = DateTime.Now;
    }
}
