using Microsoft.EntityFrameworkCore;
using MoodRadio.DB;
using MoodRadio.Models.Library;

namespace MoodRadio.Repositories.Library
{
    public class AlbumRepository : IAlbumRepository
    {
        private readonly PostgresContext context;

        public AlbumRepository(PostgresContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Album>> GetAll()
        {
            return await context.Albums.ToListAsync();
        }

        public async Task<Album> GetById(Guid id)
        {
            return await context.Albums.FindAsync(id);
        }

        public async Task Add(Album album)
        {
            context.Albums.Add(album);
            await context.SaveChangesAsync();
        }

        public async Task Update(Album album)
        {
            context.Albums.Update(album);
            await context.SaveChangesAsync();
        }

        public async Task DeleteById(Guid id)
        {
            var album = await GetById(id);
            context.Albums.Remove(album);
            await context.SaveChangesAsync();
        }
    }
}