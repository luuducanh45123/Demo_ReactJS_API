using Demo_ReactJS_API.Models;
using Demo_ReactJS_API.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace Demo_ReactJS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenController : ControllerBase
    {
        private readonly DemoDbContext _context;

        public AuthenController(DemoDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] login_request_model request)
        {
            var user = _context.Users
                .FirstOrDefault(u => u.UserName == request.UserName && u.Password == request.Password);

            if (user == null)
                return Unauthorized(new { message = "Sai tên đăng nhập hoặc mật khẩu" });

            return Ok(new
            {
                message = "Đăng nhập thành công",
                userId = user.UserId,
                username = user.UserName
            });
        }
    }
}
