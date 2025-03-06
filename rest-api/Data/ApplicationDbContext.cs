using Common.DbModels;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ProfileModel> Profile { get; set; }

        public string DbPath { get; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            var dbPath = $"{Directory.GetCurrentDirectory()}\\database";
            var dbName = "osuapp.db";

            if (!Directory.Exists(dbPath))
                Directory.CreateDirectory(dbPath);

            DbPath = $"{dbPath}\\{dbName}";
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");
    }
}
