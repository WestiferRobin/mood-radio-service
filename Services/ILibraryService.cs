using MoodRadio.Models.Library;

namespace MoodRadio.Services
{
    public interface ILibraryService
    {
        #region Artist Methods
        Task<IEnumerable<Artist>> GetAllArtists();
        Task<Artist> GetArtistById(Guid artistId);
        #endregion

        #region Album Methods
        Task<IEnumerable<Album>> GetAllAlbums();
        Task<IEnumerable<Album>> GetArtistAlbumsById(Guid artistId);
        Task<IEnumerable<Album>> GetArtistAlbums(Artist artist);
        Task<Album> GetAlbumById(Guid albumId);
        #endregion

        #region  Song Methods
        Task<IEnumerable<Song>> GetAllSongs();
        Task<IEnumerable<Song>> GetArtistSongs(Artist artist);
        Task<IEnumerable<Song>> GetAlbumSongs(Album album);
        Task<Song> GetSongById(Guid songId);
        #endregion

        // TODO: Implement this somehow => Maybe create a model instead of dtos?
        // Task<Discography> GetDiscography(Guid artistId);
        // Task<Discography> GetDiscography(Artist artist); 
    }
}