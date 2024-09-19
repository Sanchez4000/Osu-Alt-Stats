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
        public async Task<OsuClient?> GetOsuClientData()
        {
            return await _context.OsuClients.GetDefault();
        }
        [HttpPost]
        public async Task<OsuClient> SetOsuClientData([FromBody] OsuClient client)
        {
            var oldClient = await _context.OsuClients.GetDefault();

            if (oldClient != null)
            {
                oldClient.ClientId = client.ClientId;
                oldClient.ClientSecret = client.ClientSecret;
            }
            else
            {
                _context.OsuClients.Add(new OsuClient
                {
                    Id = 1,
                    ClientId = client.ClientId,
                    ClientSecret = client.ClientSecret,
                });
            }

            await _context.SaveChangesAsync();
            return await _context.OsuClients.GetDefault();
        }
    }
}
