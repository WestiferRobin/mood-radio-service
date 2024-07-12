using Microsoft.EntityFrameworkCore;
using MoodRadio.Models;

namespace MoodRadio.DB
{
    public class PostgresContext : DbContext
    {
        public static string? ConnectionString;
        public PostgresContext(DbContextOptions<PostgresContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionString!);
        }
    }
}
