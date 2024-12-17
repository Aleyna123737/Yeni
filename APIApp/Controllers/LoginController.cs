using Microsoft.AspNetCore.Mvc;

namespace APIApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Authenticate([FromBody] LoginRequest request)
        {
            if (request.Username == "admin" && request.Password == "password")
            {
                return Ok(new { message = "Başarılı giriş!" });
            }

            return Unauthorized(new { message = "Geçersiz kullanıcı adı veya şifre!" });
        }
    }

    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}