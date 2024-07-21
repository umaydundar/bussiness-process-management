using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using WebApplication2.Models;
using Microsoft.Data.SqlClient; // Newer versions might use this
using Task = System.Threading.Tasks.Task;


public class JobTitleService
{
    private readonly MANAGEMENTContext _context;

    public JobTitleService(MANAGEMENTContext context)
    {
        _context = context;
    }

    public async Task AddJobTitle(JobTitle jobTitle)
    {
        var nameParam = new SqlParameter("@Name", jobTitle.Name ?? (object)DBNull.Value);
        var timeParam = new SqlParameter("@RecordTime", jobTitle.RecordTime);

        await _context.Database.ExecuteSqlRawAsync("EXEC spAddJob_Title @Name, @RecordTime", nameParam, timeParam);
    }
    public async Task<List<JobTitle>> GetJobTitlesAsync()
    {
        return await _context.JobTitles.ToListAsync();
    }
    public async Task<List<JobTitle>> GetJobTitles()
    {
        return await _context.JobTitles.FromSqlRaw("EXEC spGetJob_Titles").ToListAsync();
    }


    public async Task<JobTitle> UpdateJobTitle(JobTitle jobTitle)
    {
        var existingJobTitle = await _context.JobTitles.FirstOrDefaultAsync(j => j.Id == jobTitle.Id);
        if (existingJobTitle == null)
        {
            return null;
        }

        existingJobTitle.Name = jobTitle.Name;
        existingJobTitle.RecordTime = jobTitle.RecordTime;

        await _context.SaveChangesAsync();
        return existingJobTitle;
    }

    public async Task DeleteJobTitle(int id)
    {
        var idParam = new SqlParameter("@Id", id);
        await _context.Database.ExecuteSqlRawAsync("EXEC spDeleteJob_Title @Id", idParam);
    }
    public async Task<JobTitle> GetJobTitle(long id)
    {
        return await _context.JobTitles
            .FirstOrDefaultAsync(j => j.Id == id);
    }

}
