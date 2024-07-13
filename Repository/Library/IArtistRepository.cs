using MoodRadio.Models.Library;

namespace MoodRadio.Repositories.Library
{
    public interface IArtistRepository
    {
        Task<IEnumerable<Artist>> GetAll();
        Task<Artist> GetById(Guid id);
        Task Add(Artist artist);
        Task Update(Artist artist);
        Task DeleteById(Guid id);
    }
}