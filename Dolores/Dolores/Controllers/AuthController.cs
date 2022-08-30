namespace Dolores.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
	using DataAccess;
	using Dolores.Authentication;
	using Domain;
	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
        private readonly JwtTokenManager _manager;

        public AuthController(JwtTokenManager manager)
        {
            _manager = manager;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Post([FromBody] TokenRequest request)
        {
            try
            {
                var token = _manager.MakeToken(request.Email, request.Password);
                return Ok(new { token });
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        public class TokenRequest
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }
    }
}
