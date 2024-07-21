using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Interfaces;
using WebApplication2.Models;

using Task = System.Threading.Tasks.Task;  // Ensures no conflict with Task entity
using TaskEntity = WebApplication2.Models.Task;  // Assuming you've renamed your Task model to TaskEntity

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskStepController : ControllerBase
    {
        private readonly MANAGEMENT_BPMContext _context;

        public TaskStepController(MANAGEMENT_BPMContext context)
        {
            _context = context;
        }

        // GET: api/Tasks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskStep>>> GetTaskSteps()
        {
            if (_context.TaskSteps == null)
            {
                return NotFound();
            }
            return await _context.TaskSteps.ToListAsync();
        }

        // GET: api/Tasks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskStep>> GetTaskStep(long id)
        {
            if (_context.TaskSteps == null)
            {
                return NotFound();
            }
            var task = await _context.TaskSteps.FindAsync(id);
            if (task == null)
            {
                return NotFound();
            }
            return task;
        }

        // PUT: api/Tasks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaskStep(long id, TaskStep task)
        {
            if (id != task.Id)
            {
                return BadRequest();
            }

            _context.Entry(task).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskStepExists(id))
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

        // POST: api/Tasks
        [HttpPost]
        public async Task<ActionResult<TaskStep>> PostTask(TaskStep task)
        {
            if (_context.TaskSteps == null)
            {
                return Problem("Entity set 'MANAGEMENT_BPMContext.Tasks' is null.");
            }
            _context.TaskSteps.Add(task);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetTask", new { id = task.Id }, task);
        }

        // DELETE: api/Tasks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTaskStep(long id)
        {
            if (_context.TaskSteps == null)
            {
                return NotFound();
            }
            var task = await _context.TaskSteps.FindAsync(id);
            if (task == null)
            {
                return NotFound();
            }

            _context.TaskSteps.Remove(task);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TaskStepExists(long id)
        {
            return (_context.TaskSteps?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}