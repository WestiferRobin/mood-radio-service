using MoodRadio.Models.Library;

namespace MoodRadio.Repositories.Library
{
    public interface ISongRepository
    {
        Task<IEnumerable<Song>> GetAll();
        Task<Song> GetById(Guid id);
        Task Add(Song song);
        Task Update(Song song);
        Task DeleteById(Guid id);
    }
}