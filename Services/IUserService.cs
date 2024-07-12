using MoodRadio.Dtos;
using MoodRadio.Models;

namespace MoodRadio.Services
{
    public interface IUserService
    {
        Task<User> GetUser(Guid id);
        // void CreateUser(CreateUserDTO createDto);
        // UserDTO UpdateUser(Guid id, UpdateDto updateDto);
    }
}