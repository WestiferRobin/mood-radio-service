using MoodRadio.Models.UserModels;
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

        // public void CreateUser(CreateUserDTO createDto)
        // {
        //     var entity = new User
        //     {
        //         UserName = createDto.UserName,
        //         FirstName = createDto.FirstName,
        //         LastName = createDto.LastName,
        //         Email = createDto.Email,
        //         BirthDate = createDto.BirthDate,
        //     };
        //     repository.Add(entity);
        // }

        // public UserDTO UpdateUser(Guid id, UpdateDto updateDto)
        // {
        //     var user = repository.GetById(id);
        //     if (user != null)
        //     {
        //         if (updateDto.UserName != null) user.UserName = updateDto.UserName;
        //         if (updateDto.FirstName != null) user.FirstName = updateDto.FirstName;
        //         if (updateDto.LastName != null) user.LastName = updateDto.LastName;
        //         if (updateDto.Email != null) user.Email = updateDto.Email;
        //         if (updateDto.BirthDate != null) user.BirthDate = updateDto.BirthDate.Value;
        //         repository.Update(user);
        //         var dto = new UserDTO()
        //         {
        //             UserName = user.UserName,
        //             FirstName = user.FirstName,
        //             LastName = user.LastName,
        //         };
        //         return dto;
        //     }
        //     throw new NullReferenceException($"User for {id} doesn't exists");
        // }
    }
}