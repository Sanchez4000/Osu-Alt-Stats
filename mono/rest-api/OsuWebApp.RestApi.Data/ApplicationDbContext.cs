using Microsoft.EntityFrameworkCore;
using OsuWebApp.RestApi.Domain.Entity;

namespace OsuWebApp.RestApi.Data
{
    public partial class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    public partial class ApplicationDbContext
    {
        public DbSet<TestData> TestData { get; set; }
    }
}
