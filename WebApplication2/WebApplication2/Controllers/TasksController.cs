using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.DTOs;
using WebApplication2.Interfaces;
using WebApplication2.Models;

using Task = System.Threading.Tasks.Task;  // Ensures no conflict with Task entity
using TaskEntity = WebApplication2.Models.Task;  // Assuming you've renamed your Task model to TaskEntity

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly MANAGEMENT_BPMContext _context;
        private readonly TaskService _service;

        public TasksController(MANAGEMENT_BPMContext context, TaskService service)
        {
            _context = context;
            _service = service;
        }

        // GET: api/Tasks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskEntity>>> GetTasks()
        {
            if (_context.Tasks == null)
            {
                return NotFound();
            }
            return await _context.Tasks.ToListAsync();
        }

        // GET: api/Tasks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskEntity>> GetTask(long id)
        {
            if (_context.Tasks == null)
            {
                return NotFound();
            }
            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
            {
                return NotFound();
            }
            return task;
        }

        // PUT: api/Tasks/5
      /*       [HttpPut("{id}")]
             public async Task<IActionResult> PutTask(long id, Task task)
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
                     if (!TaskExists(id))
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
       */

        //PUT: api/Tasks/5
        [HttpPut("{id}")]
        public async Task<ActionResult<IEnumerable<TaskEntity>>> UpdateTask(int taskId, TaskUpdateDto updateDto)
        {
            // Assuming GetHiringDetailsByTaskId returns a list, we fetch the first one as an example
            var TasksList = await _service.GetTasksById(taskId);
            if (TasksList == null || !TasksList.Any())
            {
                return NotFound($"No hiring detail found with Task ID {taskId}");
            }

            // Get the first detail for updating, assuming single task detail management for simplicity
            var task = TasksList.FirstOrDefault();
            if (task == null)
            {
                return NotFound($"No hiring detail found with Task ID {taskId}");
            }

            // Apply the updates from DTO
            if (updateDto.Name != null) task.Name = updateDto.Name;
            if (updateDto.Description != null) task.Description = updateDto.Description;
            if (updateDto.RefTaskStatus != null) task.RefTaskStatus = updateDto.RefTaskStatus;

            try
            {
                await _service.UpdateTaskAsync(task);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }


        // POST: api/Tasks
        [HttpPost]
        public async Task<ActionResult<TaskEntity>> PostTask(TaskEntity task)
        {
            if (_context.Tasks == null)
            {
                return Problem("Entity set 'MANAGEMENT_BPMContext.Tasks' is null.");
            }
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetTask", new { id = task.Id }, task);
        }


        // DELETE: api/Tasks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(long id)
        {
            if (_context.Tasks == null)
            {
                return NotFound();
            }
            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
            {
                return NotFound();
            }

            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TaskExists(long id)
        {
            return (_context.Tasks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}