using MoodRadio.Models.Library.Playlists;

namespace MoodRadio.Repositories.Library
{
    public interface IPlaylistRepository
    {
        Task<IEnumerable<Playlist>> GetAll();
        Task<Playlist> GetById(Guid id);
        Task Add(Playlist playlist);
        Task Update(Playlist playlist);
        Task DeleteById(Guid id);
    }
}