namespace MoodRadio.Dtos.LibraryDtos.Responses
{
    public class SongDto
    {
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
    }

    public class AlbumDto
    {
        public string Name { get; set; }
    }
    public class ArtistResponseDto
    {
        public string Name { get; set; }
        public List<SongDto> TopTen { get; set; }
        public List<AlbumDto> Albums { get; set; }
    }
}