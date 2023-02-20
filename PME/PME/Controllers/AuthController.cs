using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PME.Api.JwtTest;
using PME.Services.Interfaces;
using System.Threading.Tasks;

namespace PME.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;
        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserDto user)
        {
            var request = await _authRepository.Register(user);
            if(request == null) return NotFound();
            return Ok(request);
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserDto user)
        {
            var request = await _authRepository.Login(user);
            if (request == null) return NotFound();
            return Ok(request);
        }
    }
}
