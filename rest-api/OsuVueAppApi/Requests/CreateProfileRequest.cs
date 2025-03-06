using System.ComponentModel.DataAnnotations;

namespace OsuVueAppApi.Requests
{
    public class CreateProfileRequest
    {
        [Required]
        public required string Name { get; set; }
    }
}
