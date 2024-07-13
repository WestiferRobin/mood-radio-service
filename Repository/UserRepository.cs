using Microsoft.EntityFrameworkCore;
using MoodRadio.DB;
using MoodRadio.Models.UserModels;

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

        //public void Add(T entity)
        //{
        //    context.Set<T>().Add(entity);
        //    context.SaveChanges();
        //}

        //public void Update(T entity)
        //{
        //    context.Set<T>().Update(entity);
        //    context.SaveChanges();
        //}

        //public void Delete(T entity)
        //{
        //    context.Set<T>().Remove(entity);
        //    context.SaveChanges();
        //}
    }
}