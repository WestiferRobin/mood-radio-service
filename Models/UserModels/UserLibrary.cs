using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoodRadio.Models.UserModels
{
    [Table("user_libraries")]
    public class UserLibrary
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        // Todo figure this out for Playlists, Albums, Discographies, and Artists
    }
}