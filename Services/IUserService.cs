using MoodRadio.Dtos.UserDtos;
using MoodRadio.Models.Users;

namespace MoodRadio.Services
{
    public interface IUserService
    {
        Task<User> GetUser(Guid id);
        Task<UserLibraryResponseDto> GetUserLibrary(UserLibraryRequestDto request);
    }
}