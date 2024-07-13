
namespace MoodRadio.Dtos.LibraryDtos
{
    /*
        Artist => Art, Name, Type
        Album => Art, Name, Type
        Discography => Art, Name, Type

        Playlist => Art, Name, Type, Owner
        "Station" => Art, Name, Type, Genera
    */
    public abstract class LibraryItemDto
    {
        public string IconUrl { get; set; }
        public string Name { get; set; }
        public string Type { get; protected set; }
    }
}