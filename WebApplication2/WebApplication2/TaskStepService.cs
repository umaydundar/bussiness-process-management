using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication2.Models;
using Microsoft.Data.SqlClient; // Using the correct namespace for SqlParameter

public class TaskStepService
{
    private readonly MANAGEMENT_BPMContext _context;

    public TaskStepService(MANAGEMENT_BPMContext context)
    {
        _context = context;
    }

    public async Task<TaskStep> GetTaskStepAsync(int id)
    {
        var idParam = new SqlParameter("@Id", id);
        return await _context.TaskSteps // Corrected to TaskSteps for consistency
                             .FromSqlRaw("EXEC sp_GetTaskStep @Id", idParam)
                             .AsNoTracking()
                             .FirstOrDefaultAsync();
    }

    public async Task<List<TaskStep>> GetTaskStepsAsync()
    {
        return await _context.TaskSteps.ToListAsync();
    }

    public async Task<List<TaskStep>> GetTaskSteps()
    {
        return await _context.TaskSteps.FromSqlRaw("EXEC spGetTask_Steps").ToListAsync();
    }

    public async Task<bool> InsertTaskStepAsync(TaskStep task)
    {
        var sqlParams = new SqlParameter[]
        {
            new SqlParameter("@Id", task.Id),
            new SqlParameter("@Description", task.Description ?? (object)DBNull.Value),
            new SqlParameter("@StepStatus", task.StepStatus ?? (object)DBNull.Value),
            // Add other parameters as needed
        };

        var result = await _context.Database.ExecuteSqlRawAsync("EXEC sp_InsertTaskStep @Name, @Description", sqlParams);
        return result > 0;
    }

    public async Task<bool> UpdateTaskStepAsync(TaskStep task)
    {
        var sqlParams = new SqlParameter[]
        {
            new SqlParameter("@Id", task.Id),
            new SqlParameter("@Description", task.Description ?? (object)DBNull.Value),
            // Add other parameters as needed
        };

        var result = await _context.Database.ExecuteSqlRawAsync("EXEC sp_UpdateTaskStep @Id, @Name, @Description", sqlParams);
        return result > 0;
    }

    public async Task<bool> DeleteTaskStepAsync(int id)
    {
        var idParam = new SqlParameter("@Id", id);
        var result = await _context.Database.ExecuteSqlRawAsync("EXEC sp_DeleteTaskStep @Id", idParam);
        return result > 0;
    }
}
