using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLogsController : ControllerBase
    {
        private readonly MANAGEMENT_BPMContext _context;

        public UserLogsController(MANAGEMENT_BPMContext context)
        {
            _context = context;
        }

        // GET: api/UserLogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserLog>>> GetUserLogs()
        {
            if (_context.UserLogs == null)
            {
                return NotFound();
            }
            return await _context.UserLogs.ToListAsync();
        }

        // GET: api/UserLogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserLog>> GetUserLog(long id)
        {
            if (_context.UserLogs == null)
            {
                return NotFound();
            }
            var userLog = await _context.UserLogs.FindAsync(id);
            if (userLog == null)
            {
                return NotFound();
            }
            return userLog;
        }

        // PUT: api/UserLogs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserLog(long id, UserLog userLog)
        {
            if (id != userLog.Id)
            {
                return BadRequest();
            }

            _context.Entry(userLog).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserLogExists(id))
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

        // POST: api/UserLogs
        [HttpPost]
        public async Task<ActionResult<UserLog>> PostUserLog(UserLog userLog)
        {
            if (_context.UserLogs == null)
            {
                return Problem("Entity set 'MANAGEMENT_BPMContext.UserLogs' is null.");
            }
            _context.UserLogs.Add(userLog);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetUserLog), new { id = userLog.Id }, userLog);
        }

        // DELETE: api/UserLogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserLog(long id)
        {
            if (_context.UserLogs == null)
            {
                return NotFound();
            }
            var userLog = await _context.UserLogs.FindAsync(id);
            if (userLog == null)
            {
                return NotFound();
            }

            _context.UserLogs.Remove(userLog);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserLogExists(long id)
        {
            return (_context.UserLogs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
