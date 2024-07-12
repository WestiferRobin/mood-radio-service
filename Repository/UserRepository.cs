using MoodRadio.DB;

namespace MoodRadio.Repositories
{
    public class UserRepository<T> : IUserRepository<T> where T : class
    {
        private readonly PostgresContext context;

        public UserRepository(PostgresContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetById(Guid id)
        {
            var result = context.Set<T>().Find(id);
            return result ?? throw new Exception("This ain't right");
        }

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }
    }
}