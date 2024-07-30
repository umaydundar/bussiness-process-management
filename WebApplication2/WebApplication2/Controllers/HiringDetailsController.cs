using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models; // Adjust the namespace according to your project
using WebApplication2.DTOs;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HiringDetailsController : ControllerBase
    {
        private readonly HiringDetailsService _hiringDetailsService;
        private readonly MANAGEMENT_BPMContext _context;

        public HiringDetailsController(HiringDetailsService hiringDetailsService, MANAGEMENT_BPMContext context)
        {
            _hiringDetailsService = hiringDetailsService;
            _context = context;
        }


        // GET: api/HiringDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HiringDetails>>> GetHiringDetails()
        {
            var hiringDetails = await _hiringDetailsService.GetAllHiringDetails();
            if (hiringDetails == null || hiringDetails.Count == 0)
            {
                return NotFound();
            }
            return Ok(hiringDetails);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<HiringDetails>> GetHiringDetail(int id)
        {
            var hiringDetail = await _hiringDetailsService.GetHiringDetail(id);
            if (hiringDetail == null)
            {
                return NotFound();
            }
            return Ok(hiringDetail);
        }

        [HttpGet("ByTask/{taskId}")]
        public async Task<ActionResult<IEnumerable<HiringDetails>>> GetHiringDetailsByTaskId(int taskId)
        {
            var hiringDetails = await _hiringDetailsService.GetHiringDetailsByTaskId(taskId);
            if (hiringDetails == null || !hiringDetails.Any())
            {
                return NotFound();
            }
            return Ok(hiringDetails);
        }

        // Update the PUT method to accept taskId and use the DTO
        [HttpPut("ByTask/{taskId}")]
        public async Task<IActionResult> UpdateHiringDetailsByTask(int taskId, HiringDetailsUpdateDto updateDto)
        {
            // Assuming GetHiringDetailsByTaskId returns a list, we fetch the first one as an example
            var hiringDetailsList = await _hiringDetailsService.GetHiringDetailsByTaskId(taskId);
            if (hiringDetailsList == null || !hiringDetailsList.Any())
            {
                return NotFound($"No hiring detail found with Task ID {taskId}");
            }

            // Get the first detail for updating, assuming single task detail management for simplicity
            var hiringDetail = hiringDetailsList.FirstOrDefault();
            if (hiringDetail == null)
            {
                return NotFound($"No hiring detail found with Task ID {taskId}");
            }

            // Apply the updates from DTO
            if (updateDto.HireName != null) hiringDetail.HireName = updateDto.HireName;
            if (updateDto.Department != null) hiringDetail.Department = updateDto.Department;
            if (updateDto.Status != null) hiringDetail.Status = updateDto.Status;

            try
            {
                // Assuming UpdateHiringDetail handles saving changes
                await _hiringDetailsService.UpdateHiringDetail(hiringDetail);
                return NoContent(); // Or return Ok(hiringDetail) if you prefer to return the updated detail
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }
        [HttpPost("UpdateStatus/{taskId}")]
        public async Task<IActionResult> UpdateStatus(int taskId, [FromBody] Status2Update updateDto)
        {
            var hiringDetails = await _context.HiringDetails.FirstOrDefaultAsync(hd => hd.TaskID == taskId);
            if (hiringDetails == null)
            {
                return NotFound();
            }

            // Update fields as necessary
            hiringDetails.Status2 = updateDto.Status2;

            try
            {
                await _context.SaveChangesAsync();
                return NoContent(); // Or return the updated data
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HiringDetailsExists(taskId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }

        private bool HiringDetailsExists(int taskId) => _context.HiringDetails.Any(e => e.TaskID == taskId);

        [HttpPost("UpdateStatus3/{taskId}")]
        public async Task<IActionResult> UpdateStatus3(int taskId, [FromBody] Status3Update updateDto)
        {
            var hiringDetails = await _context.HiringDetails.FirstOrDefaultAsync(hd => hd.TaskID == taskId);
            if (hiringDetails == null)
            {
                return NotFound();
            }

            // Update fields as necessary
            hiringDetails.Status3 = updateDto.Status3;

            try
            {
                await _context.SaveChangesAsync();
                return NoContent(); // Or return the updated data
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HiringDetailsExists2(taskId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }

        private bool HiringDetailsExists2(int taskId) => _context.HiringDetails.Any(e => e.TaskID == taskId);


        // POST: api/HiringDetails
        [HttpPost]
        public async Task<ActionResult<HiringDetails>> PostHiringDetail(HiringDetails hiringDetail)
        {
            var result = await _hiringDetailsService.AddHiringDetail(hiringDetail);
            if (!result)
            {
                return Problem("Hiring detail could not be created.");
            }
            return CreatedAtAction("GetHiringDetail", new { id = hiringDetail.DetailID }, hiringDetail);
        }

        // DELETE: api/HiringDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHiringDetail(int id)
        {
            var result = await _hiringDetailsService.DeleteHiringDetail(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }

        private async Task<bool> HiringDetailExists(int id)
        {
            var hiringDetail = await _hiringDetailsService.GetHiringDetail(id);
            return hiringDetail != null;
        }
    }
}
