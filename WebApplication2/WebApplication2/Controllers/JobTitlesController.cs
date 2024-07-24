using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication2.Models;  // Use your actual namespace
using WebApplication2;  // Assuming JobTitleService is in the Services folder/namespace

namespace WebApplication2.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    [Route("api/[controller]")]
    public class JobTitlesController : ControllerBase
    {
        private readonly JobTitleService _jobTitleService;
        private readonly MANAGEMENTContext _context;

        public JobTitlesController(MANAGEMENTContext context)
        {
            _context = context;
        }

        //public JobTitlesController(JobTitleService jobTitleService)
        //{
        //    _jobTitleService = jobTitleService;
        //}

        ////// GET: api/JobTitles
        ////[HttpGet]
        ////public async Task<IActionResult> GetJobTitles()
        ////{
        ////    var jobTitles = await _jobTitleService.GetJobTitles();
        ////    return Ok(jobTitles);
        ////}
        //// GET: api/JobTitles
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<JobTitle>>> GetJobTitles()
        //{
        //    Console.WriteLine("Merhaba");
        //    var jobTitles = await _jobTitleService.GetJobTitlesAsync();
        //    Console.WriteLine("Merhaba");
        //    return Ok(jobTitles);
        //}

        private readonly ILogger<JobTitlesController> _logger;

        public JobTitlesController(JobTitleService jobTitleService, ILogger<JobTitlesController> logger)
        {
            _jobTitleService = jobTitleService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobTitle>>> GetJobTitles()
        {
            _logger.LogInformation("Getting job titles");
            var jobTitles = await _jobTitleService.GetJobTitlesAsync();
            return Ok(jobTitles);
        }

        // GET: api/JobTitles/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetJobTitle(long id)
        {
            var jobTitle = await _jobTitleService.GetJobTitle(id);
            if (jobTitle == null)
            {
                return NotFound();
            }
            return Ok(jobTitle);
        }


        // POST: api/JobTitles
        [HttpPost]
        public async Task<IActionResult> AddJobTitle(JobTitle jobTitle)
        {
            await _jobTitleService.AddJobTitle(jobTitle);
            return CreatedAtAction(nameof(GetJobTitle), new { id = jobTitle.Id }, jobTitle);
        }

        // More actions here...


        // DELETE: api/JobTitles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJobTitle(int id)
        {
            var jobTitle = await _jobTitleService.GetJobTitle(id);
            if (jobTitle == null)
            {
                return NotFound($"Job Title with Id = {id} not found.");
            }

            await _jobTitleService.DeleteJobTitle(id);
            return NoContent();  // Indicates successful deletion without sending any content back
        }

        // PUT: api/JobTitles/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateJobTitle(long id, JobTitle jobTitle)
        {
            if (id != jobTitle.Id)
            {
                return BadRequest("Job Title ID mismatch");
            }

            var result = await _jobTitleService.UpdateJobTitle(jobTitle);
            if (result == null)
            {
                return NotFound($"Job Title with Id = {id} not found.");
            }

            return NoContent();  // You can also return Ok(result) if you prefer to return the updated object
        }

    }



}
