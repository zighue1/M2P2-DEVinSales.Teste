using DevInSales.api.DTOs;
using DevInSales.api.Services;
using DevInSales.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevInSales.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {

        private readonly SqlContext _context;

        public AuthenticationController(SqlContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Login([FromBody] UserLoginDTO dto)
        {

            var user = _context.User.Include(x=>x.Profile).FirstOrDefault(x=>x.Id == dto.Id && x.Password == dto.Password);

            if (user == null) return NotFound();

            var token = TokenService.GenerateToken(user);
           // var newRefreshToken = TokenService.GenerateRefreshToken();
           // TokenService.SaveRefreshToken(user.Username, newRefreshToken);

            return Ok(new
            {
                token
            });

        }

      
       
    }
}
