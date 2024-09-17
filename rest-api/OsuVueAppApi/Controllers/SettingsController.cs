using Microsoft.AspNetCore.Mvc;
using OsuVueAppApi.Data;
using OsuVueAppApi.Extensions;
using OsuVueAppApi.Models.Database;

namespace OsuVueAppApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SettingsController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;

        [HttpPost]
        public async Task<Settings> Load()
        {
            return new Settings
            {
                OsuClient = await _context.OsuClients.GetDefault(),
            };
        }
        [HttpPost]
        public async Task Save([FromBody] Settings settings)
        {
            if (settings.OsuClient != null)
            {
                var client = await _context.OsuClients.GetDefault();
                
                if (client == null)
                {
                    _context.OsuClients.Add(new OsuClient
                    {
                        Id = 1,
                        ClientId = settings.OsuClient.ClientId,
                        ClientSecret = settings.OsuClient.ClientSecret
                    });
                }
                else
                {
                    client.ClientId = settings.OsuClient.ClientId;
                    client.ClientSecret = settings.OsuClient.ClientSecret;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}
