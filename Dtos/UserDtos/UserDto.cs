
namespace MoodRadio.Dtos.UserDtos

{
    public class UserDto
    {
        public string Username { get; set; }

        public UserDto(string username)
        {
            this.Username = username;
        }
    }
}