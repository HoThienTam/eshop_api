using ApplicationCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PublicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUsersController : ControllerBase
    {
        private readonly IIdentityService _identityService;

        public ApplicationUsersController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(string username, string email, string password)
        {
            await _identityService.CreateUserAsync(username, email, password);
            return Ok();
        }
    }
}
