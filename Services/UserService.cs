using MoodRadio.Dtos.LibraryDtos;
using MoodRadio.Dtos.UserDtos;
using MoodRadio.Models.Users;
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

        public async Task<User> GetUser(Guid id)
        {
            return await repository.GetById(id);
        }

        // TODO: Finish this
        public async Task<UserLibraryResponseDto> GetUserLibrary(UserLibraryRequestDto request)
        {
            var user = await GetUser(request.Id);
            var ans = new UserLibraryResponseDto();
            return ans;
        }
    }
}