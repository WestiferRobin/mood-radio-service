
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MoodRadio.Dtos;
using MoodRadio.Services;

namespace MoodRadio
{
    [ApiController]
    [EnableCors("CorsPolicy")]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly ILogger<UserController> logger;
        private readonly IMapper mapper;

        public UserController(IUserService userService, ILogger<UserController> logger, IMapper mapper)
        {
            this.userService = userService;
            this.logger = logger;
            this.mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var user = await userService.GetUser(id);
            if (user == null)
            {
                logger.LogInformation($"User not found for: {id}");
                return NotFound();
            }
            logger.LogInformation($"Found user: {user.UserName}");
            var userDto = mapper.Map<UserDto>(user);
            return Ok(userDto);
        }
    }
}



