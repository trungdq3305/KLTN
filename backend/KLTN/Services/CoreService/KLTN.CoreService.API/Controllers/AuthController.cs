using KLTN.CoreService.Application.Applications;
using KLTN.CoreService.Application.DTOs.AuthDtos;
using KLTN.CoreService.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KLTN.CoreService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthApplication _authApplication;

        public AuthController(IAuthApplication authApplication)
        {
            _authApplication = authApplication;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            var token = await _authApplication.LoginAsync(request);
            if (token == null)
                return Unauthorized(new { message = "Invalid credentials" });

            return Ok(new { token });
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            var result = await _authApplication.RegisterAsync(request);
            if (!result)
                return BadRequest(new { message = "email already exists" });

            return Ok(new { message = "User registered successfully" });
        }
    }
}
