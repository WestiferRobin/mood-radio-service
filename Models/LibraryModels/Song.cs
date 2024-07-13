using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoodRadio.Models.LibraryModels
{
    [Table("songs")]
    public class Song
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Required]
        [Column("title")]
        public string Title { get; set; }

        [Required]
        [Column("duration")]
        public TimeSpan Duration { get; set; }

        [Required]
        [Column("album_id")]
        public Guid AlbumId { get; set; }
        [ForeignKey("AlbumId")]
        public Album Album { get; set; }

        [Required]
        [Column("artist_id")]
        public Guid ArtistId { get; set; }
        [ForeignKey("ArtistId")]
        public Artist Artist { get; set; }
    }
}