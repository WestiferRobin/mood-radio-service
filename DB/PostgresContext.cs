using Microsoft.EntityFrameworkCore;
using MoodRadio.Models.LibraryModels;
using MoodRadio.Models.UserModels;

namespace MoodRadio.DB
{
    public class PostgresContext : DbContext
    {
        public static string? ConnectionString;

        public PostgresContext(DbContextOptions<PostgresContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionString!);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure one-to-many relationship between Artist and Album
            modelBuilder.Entity<Album>()
                .HasOne(a => a.Artist)
                .WithMany(artist => artist.Albums)
                .HasForeignKey(a => a.ArtistId);

            // Configure one-to-many relationship between Artist and Song
            modelBuilder.Entity<Song>()
                .HasOne(s => s.Artist)
                .WithMany(artist => artist.Songs)
                .HasForeignKey(s => s.ArtistId);

            // Configure one-to-many relationship between Album and Song
            modelBuilder.Entity<Song>()
                .HasOne(s => s.Album)
                .WithMany(album => album.Songs)
                .HasForeignKey(s => s.AlbumId);
        }
    }
}
