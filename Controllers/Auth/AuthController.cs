using Microsoft.AspNetCore.Mvc;
using p_2_p_backend.Context;
using p_2_p_backend.Models.User;
using System.Security.Cryptography;

namespace p_2_p_backend.Controllers.Auth
{
    public class AuthController : ControllerBase
    {


        private User user = new User();
        private AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public ActionResult<User> Register(UserDto request)
        {
            CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

            user.Username = request.Username;
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            _context.Add(user);
            _context.SaveChanges();
            return Ok(user);
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
