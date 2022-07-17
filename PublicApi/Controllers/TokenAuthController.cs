using ApplicationCore.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PublicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenAuthController : ControllerBase
    {
        private readonly IIdentityService _identityService;

        public TokenAuthController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate(string username, string password)
        {
            var token  = await _identityService.Authenticate(username, password);

            return Ok(token);
        }
    }
}
