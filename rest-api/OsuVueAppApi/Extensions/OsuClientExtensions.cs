using Microsoft.EntityFrameworkCore;
using OsuVueAppApi.Models.Database;

namespace OsuVueAppApi.Extensions
{
    public static class OsuClientExtensions
    {
        public static async Task<OsuClient?> GetDefault(this DbSet<OsuClient> source)
        {
            return await source.Where(x => x.Id == 1).FirstOrDefaultAsync();
        }
    }
}
