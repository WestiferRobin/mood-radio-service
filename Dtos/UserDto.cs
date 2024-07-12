
namespace MoodRadio.Dtos
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