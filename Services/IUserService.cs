using MoodRadio.Dtos;

namespace MoodRadio.Services
{
    public interface IUserService
    {
        UserDto GetUser(Guid id);
        // void CreateUser(CreateUserDTO createDto);
        // UserDTO UpdateUser(Guid id, UpdateDto updateDto);
    }
}