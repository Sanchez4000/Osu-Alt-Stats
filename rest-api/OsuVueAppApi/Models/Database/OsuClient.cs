using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace OsuVueAppApi.Models.Database
{
    [PrimaryKey(nameof(Id))]
    public class OsuClient
    {
        [Key] public int Id { get; set; }
        public int ClientId { get; set; }
        public string ClientSecret { get; set; } = string.Empty;
    }
}
