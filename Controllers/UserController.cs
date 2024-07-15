
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MoodRadio.Dtos;
using MoodRadio.Services;

namespace MoodRadio.Controllers
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

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await userService.GetAllUsers();
            if (!users.Any()) return NotFound("There are no users");
            
            var userDtos = new List<UserDto>();
            foreach (var user in users)
            {
                var userDto = mapper.Map<UserDto>(user);
                userDtos.Add(userDto);
            }

            return Ok(userDtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(Guid id)
        {
            var user = await userService.GetUser(id);
            if (user == null)
            {
                logger.LogInformation($"User not found for: {id}");
                return NotFound();
            }
            
            var userDto = mapper.Map<UserDto>(user);
            logger.LogInformation($"Found user: {userDto.Username}");
            
            return Ok(userDto);
        }


    }
}



