using Microsoft.AspNetCore.Mvc;
using AspNetCoreIntro.Services;

namespace AspNetCoreIntro.wwwroot.UsersApi
{
    [ApiController]
    [Route("api/[controller]")]

    public class UsersApiController : ControllerBase
    {
        private readonly IUsersService _usersService;

        // Public constructor for DI
        public UsersApiController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        
        // GET api/users
        public IActionResult Get()
        {
            var users = _userService.GetUsers();
            return Ok(users);
        }



        // GET api/usersapi/{id utente}
        [HttpGet("cerca/{userId}")]


        // GET api/usersapi/{id utente}
        [HttpGet("{userId}")]

        public IActionResult GetUserDetail(int userId)
        {
            var user = _userService.GetUserById(userId);
            return Ok(user);
        }
    }
}
