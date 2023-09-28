using Microsoft.AspNetCore.Mvc;
using AUTH.Backend.Domains.Responses;
using AUTH.Backend.Domains.Requests;
using AUTH.Backend.Managers;

namespace AUTH.Backend.Controllers.User
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IUserManager _userManager;

        public UsersController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        [HttpPost("signup")]
        public async Task<IActionResult> SignUp([FromBody] SignUpRequest request)
        {
            TokenResponse result = await _userManager.SignUp(request);
            return Ok(result);
        }
    }
}