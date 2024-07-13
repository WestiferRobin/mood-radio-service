using MoodRadio.Models.Library;

namespace MoodRadio.Repositories.Library
{
    public interface IAlbumRepository
    {
        Task<IEnumerable<Album>> GetAll();
        Task<Album> GetById(Guid id);
        Task Add(Album album);
        Task Update(Album album);
        Task DeleteById(Guid id);
    }
}