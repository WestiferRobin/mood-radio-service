
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MoodRadio.Dtos;

namespace MoodRadio
{
    [ApiController]
    [EnableCors("CorsPolicy")]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private static readonly string TestUser = "WestiferRobin";

        private readonly ILogger<UserController> logger;

        public UserController(ILogger<UserController> logger)
        {
            this.logger = logger;
        }

        [HttpGet(Name = "GetTestUser")]
        public UserDto Get()
        {
            return new UserDto(TestUser);
        }
    }
}



