namespace MoodRadio.Dtos.LibraryDtos
{

    public class AlbumNameDto
    {
        public string Name { get; set; }
    }

    public class AlbumDto: AlbumNameDto
    {
        public List<SongDto> Songs { get; set; }
    }
}