using MoodRadio.Models.Users;

namespace MoodRadio.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();
        Task<User?> GetById(Guid id);
        //void Add(T entity);
        //void Update(T entity);
        //void Delete(T entity);
    }
}