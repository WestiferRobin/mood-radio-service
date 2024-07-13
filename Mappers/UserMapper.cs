using AutoMapper;
using MoodRadio.Dtos.UserDtos;
using MoodRadio.Models.Users;

namespace MoodRadio.Mappers
{
    public class UserMapper : Profile
    {
        public UserMapper() 
        {
            CreateMap<User, UserDto>();
        }
    }
}
