using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace RSVP_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet("login")]
        public IActionResult Login()
        {
            string authHeader = Request.Headers["Authorization"].ToString();

            if (string.IsNullOrEmpty(authHeader) || !authHeader.StartsWith("Basic "))
            {
                return Unauthorized();
            }

            string encodedCredentials = authHeader.Substring("Basic ".Length).Trim();

            string decodedCredentials = Encoding.UTF8.GetString(Convert.FromBase64String(encodedCredentials));

            string[] values = decodedCredentials.Split(':');

            if (values.Length != 2)
            {
                return Unauthorized();
            }

            string username = values[0];
            string password = values[1];

            //Test Credentials
            if (username == "eventhost" && password == "Password1")
            {
                return Ok("Login successful");
            }
            else
            {
                return Unauthorized("Invalid username or Password");
            }
        }
    }
}
