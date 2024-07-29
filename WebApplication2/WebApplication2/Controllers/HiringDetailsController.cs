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

        public HiringDetailsController(HiringDetailsService hiringDetailsService)
        {
            _hiringDetailsService = hiringDetailsService;
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

        // PUT: api/HiringDetails/5
        // PUT: api/HiringDetails/5
        // PUT: api/HiringDetails/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateHiringDetails(int id, HiringDetails hiringDetails)
        //{
        //    if (id != hiringDetails.DetailID)
        //    {
        //        return BadRequest("Mismatched ID in request");
        //    }

        //    try
        //    {
        //        // Assuming that the UpdateHiringDetail method can handle the business logic needed to update the details.
        //        var result = await _hiringDetailsService.UpdateHiringDetail(hiringDetails);
        //        if (!result)
        //        {
        //            if (!await HiringDetailExists(id))
        //            {
        //                return NotFound($"No hiring detail found with ID {id}");
        //            }
        //            else
        //            {
        //                return Problem("Update operation failed, but the entry exists.");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Log the exception details here if necessary
        //        return StatusCode(500, "Internal server error: " + ex.Message);
        //    }

        //    return NoContent(); // Or return Ok() if you prefer to send some acknowledgment back to the client.
        //}
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutHiringDetails(int id, HiringDetails hiringDetails)
        //{
        //    if (id != hiringDetails.DetailID)
        //    {
        //        return BadRequest("Mismatched ID in request");
        //    }

        //    var existingDetail = await _hiringDetailsService.GetHiringDetail(id);
        //    if (existingDetail == null)
        //    {
        //        return NotFound();
        //    }

        //    // Update only the fields that are present in the request
        //    existingDetail.HireName = hiringDetails.HireName ?? existingDetail.HireName;
        //    existingDetail.Department = hiringDetails.Department ?? existingDetail.Department;
        //    existingDetail.Status = hiringDetails.Status ?? existingDetail.Status;
        //    // Repeat for other fields

        //    try
        //    {
        //        var result = await _hiringDetailsService.UpdateHiringDetail(existingDetail);
        //        if (!result)
        //        {
        //            return Problem("Update operation failed.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, "Internal server error: " + ex.Message);
        //    }

        //    return NoContent();
        //}


        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutHiringDetails(int id, HiringDetails hiringDetails)
        //{
        //    if (id != hiringDetails.DetailID)
        //    {
        //        return BadRequest();
        //    }

        //    try
        //    {
        //        var result = await _hiringDetailsService.UpdateHiringDetail(hiringDetails);
        //        if (!result)
        //        {
        //            if (!await HiringDetailExists(id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                // This section can be a place to throw an exception if you expect one to occur.
        //                return Problem("Update operation failed, but the entry exists.");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Log the exception details here if necessary
        //        throw new InvalidOperationException("Error occurred during the update operation.", ex);
        //    }

        //    return NoContent();
        //}


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
