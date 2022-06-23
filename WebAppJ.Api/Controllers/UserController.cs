using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppJ.BL.Interfaces;

namespace WebAppJ.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly ILogger logger;

        public UserController(IUserService userService, ILogger<UserController> logger)
        {
            this.logger = logger;
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult GetUser()
        {
            var user = userService.GetUser();
            logger.LogInformation("Method GetUser called");

            return Ok(user);
        }

    }
}
