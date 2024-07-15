using MoodRadio.Models;
using MoodRadio.Repositories;

namespace MoodRadio.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository repository;

        public UserService(IUserRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await repository.GetAll();
        }

        public async Task<User> GetUser(Guid id)
        {
            return await repository.GetById(id);
        }
    }
}