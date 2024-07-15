using Microsoft.EntityFrameworkCore;
using MoodRadio.DB;
using MoodRadio.Models;

namespace MoodRadio.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PostgresContext context;

        public UserRepository(PostgresContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<User> GetById(Guid id)
        {
            return await context.Users.FindAsync(id);
        }

        public async Task Add(User user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();
        }

        public async Task Update(User user)
        {
            context.Users.Update(user);
            await context.SaveChangesAsync();
        }

        public async Task DeleteById(Guid id)
        {
            var user = await GetById(id);
            context.Users.Remove(user);
            await context.SaveChangesAsync();
        }
    }
}