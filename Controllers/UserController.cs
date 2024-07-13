
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MoodRadio.Dtos.UserDtos;
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

        // /user/library => POST
        [HttpPost("/library")]
        public async Task<IActionResult> GetUserLibrary([FromBody] UserLibraryRequestDto request)
        {
            var response = await userService.GetUserLibrary(request);
            if (response == null)
            {
                logger.LogError($"User's Library is not found for {request}");
            }

            logger.LogInformation($"User's Library is found {response}");

            return Ok(response);
        }
    }
}



