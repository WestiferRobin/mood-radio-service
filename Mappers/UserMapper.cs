using AutoMapper;
using MoodRadio.Dtos.UserDtos;
using MoodRadio.Models.UserModels;

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
