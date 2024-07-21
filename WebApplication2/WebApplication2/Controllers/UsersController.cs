using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
using System.Threading.Tasks;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly MANAGEMENTContext _context;

        public UsersController(MANAGEMENTContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            if (_context.Users == null)
            {
                return NotFound();
            }
            return await _context.Users.ToListAsync();
        }
        [HttpGet("login")]
        public async Task<ActionResult<User>> Login(string email, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);

            if (user != null && VerifyPasswordHash(password, user.Password))
            {
                return Ok(user); // Limit the data returned for security purposes
            }
            return Unauthorized("Invalid credentials");
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(long id)
        {
            if (_context.Users == null)
            {
                return NotFound();
            }
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        //// POST: api/Users
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            if (_context.Users == null)
            {
                return Problem("Entity set 'MANAGEMENTContext.Users' is null.");
            }
            user.Password = CreatePasswordHash(user.Password);  // Hash the password before storing it
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] User login)
        {
            var user = await _context.Users
                                     .SingleOrDefaultAsync(u => u.Email == login.Email && u.Password == login.Password);

            if (user == null)
            {
                return Unauthorized("Invalid credentials.");
            }

            return Ok(new { Message = "Login successful", UserId = user.Id });
        }

        //[HttpPost("login")]
        //public async Task<ActionResult> Login([FromBody] User login)
        //{
        //    var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == login.Email);
        //    if (user == null)
        //    {
        //        return Unauthorized("User not found.");
        //    }

        //    if (!BCrypt.Net.BCrypt.Verify(login.Password, user.Password))
        //    {
        //        return Unauthorized("Invalid credentials.");
        //    }

        //    return Ok(new { Message = "Login successful", UserId = user.Id, UserName = user.Name });
        //}



        // PUT: api/Users/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(long id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            user.Password = CreatePasswordHash(user.Password);  // Update the password hash
            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(long id)
        {
            if (_context.Users == null)
            {
                return NotFound();
            }
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/Users/login
        //[HttpPost("login")]
        //public async Task<ActionResult<User>> Login(User login)
        //{
        //    var user = await _context.Users
        //                              .FirstOrDefaultAsync(u => u.Email == login.Email);

        //    if (user == null || !VerifyPasswordHash(login.Password, user.Password))
        //    {
        //        return Unauthorized("Invalid credentials");
        //    }

        //    return user;
        //}

        private bool UserExists(long id)
        {
            return (_context.Users?.Any(e => e.Id == id)).GetValueOrDefault();
        }



        // Using BCrypt
        private string CreatePasswordHash(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        private bool VerifyPasswordHash(string password, string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, storedHash);
        }



    }
}
