using AutoMapper;
using Entities.Interfaces.Services;
using Entities.Models.UserAggregate;
using Entities.ViewModels.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration; 
        private readonly IMapper _mapper;
        
        public UserController(IUserService userService, IMapper mapper, IConfiguration configuration)
        {
            _configuration = configuration;
            _userService = userService;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]UserViewModel userParam)
        {
            var user = _userService.Authenticate(userParam.Name, userParam.Password, _configuration["AppSettings:SecurityKey"]);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

        [AllowAnonymous]
        [HttpPost("addUser")]
        public void AddUser([FromBody] UserViewModel userParam)
        {
            _userService.AddUser(_mapper.Map<User>(userParam));
        }

    }
}
