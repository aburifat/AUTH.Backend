using AUTH.Backend.Managers;
using AUTH.Backend.Repository.Models;
using AUTH.Backend.Repository.Requests;
using Microsoft.AspNetCore.Mvc;

namespace AUTH.Backend.Controllers;

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
        TokenViewModel result = await _userManager.SignUp(request);
        return Ok(result);
    }
}
