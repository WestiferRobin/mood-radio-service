// using Microsoft.EntityFrameworkCore;
// using MoodRadio.DB;
// using MoodRadio.Models.Library;

// namespace MoodRadio.Repositories.Library
// {
//     public class PlaylistRepository : IPlaylistRepository
//     {
//         private readonly PostgresContext context;

//         public PlaylistRepository(PostgresContext context)
//         {
//             this.context = context;
//         }

//         public async Task<IEnumerable<Playlist>> GetAll()
//         {
//             return await context.Playlists.ToListAsync();
//         }

//         public async Task<Playlist> GetById(Guid id)
//         {
//             return await context.Playlists.FindAsync(id);
//         }

//         public async Task Add(Playlist playlist)
//         {
//             context.Playlists.Add(playlist);
//             await context.SaveChangesAsync();
//         }

//         public async Task Update(Playlist playlist)
//         {
//             context.Playlists.Update(playlist);
//             await context.SaveChangesAsync();
//         }

//         public async Task DeleteById(Guid id)
//         {
//             var playlist = await GetById(id);
//             context.Playlists.Remove(playlist);
//             await context.SaveChangesAsync();
//         }
//     }
// }