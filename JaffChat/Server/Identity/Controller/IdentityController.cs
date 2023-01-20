using JaffChat.Server.Identity.Models;
//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JaffChat.Server.Identity.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly SignInManager<ApplicationUser> _signInManager;

        public IdentityController(SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            ApplicationUser newUser = new()
            {
                Email = request.Email,
                UserName = request.Username,
                NickName = request.Username
            };

            try
            {
                var registerResult = await _signInManager.UserManager.CreateAsync(newUser, request.Password);

                if (registerResult.Succeeded)
                {
                    return StatusCode(StatusCodes.Status201Created);
                }

                return BadRequest(registerResult.Errors);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server error");
            }
            
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Login(LoginRequest login)
        {
            var user = await _signInManager.UserManager.Users.FirstOrDefaultAsync(u => u.Email == login.Email);

            var result = await _signInManager.UserManager.CheckPasswordAsync(user, login.Password);

            if (!result)
            {
                return Unauthorized("Wrong password");

            }

            return Ok("Välkommen");


        }
    }
}
