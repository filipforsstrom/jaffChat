using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JaffChat.Server.Identity.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        public IdentityController()
        {

        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Register()
        {


            return null;
        }
    }
}
