using MoodRadio.Models;

namespace MoodRadio.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUser(Guid id);
        // Task<UserLibraryResponseDto> GetUserLibrary(UserLibraryRequestDto request);
    }
}