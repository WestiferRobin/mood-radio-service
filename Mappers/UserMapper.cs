using AutoMapper;
using MoodRadio.Dtos;
using MoodRadio.Models;

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
