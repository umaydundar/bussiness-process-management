using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using WebApplication2.Models;
using Microsoft.Data.SqlClient; // This is necessary if you're using a newer version
using Task = System.Threading.Tasks.Task;  // Ensures no conflict with Task entity
using TaskEntity = WebApplication2.Models.Task;  // Assuming you've renamed your Task model to TaskEntity

public class TaskService 
{
    private readonly MANAGEMENT_BPMContext _context;

    public TaskService(MANAGEMENT_BPMContext context)
    {
        _context = context;
    }

    public async Task<TaskEntity> GetTaskAsync(int id)
    {
        var idParam = new SqlParameter("@Id", id);
        return await _context.Tasks
                             .FromSqlRaw("EXEC sp_GetTask @Id", idParam)
                             .AsNoTracking()
                             .FirstOrDefaultAsync();
    }

    public async Task<bool> InsertTaskAsync(TaskEntity task)
    {
        var sqlParams = new SqlParameter[]
        {
        new SqlParameter("@Name", task.Name ?? (object)DBNull.Value),
        new SqlParameter("@Description", task.Description ?? (object)DBNull.Value),
            // Add other parameters as needed
        };

        var result = await _context.Database.ExecuteSqlRawAsync("EXEC sp_InsertTask @Name, @Description", sqlParams);
        return result > 0;
    }

    public async Task<bool> UpdateTaskAsync(TaskEntity task)
    {
        var sqlParams = new SqlParameter[]
        {
        new SqlParameter("@Id", task.Id),
        new SqlParameter("@Name", task.Name ?? (object)DBNull.Value),
            // Add other parameters as needed
        };

        var result = await _context.Database.ExecuteSqlRawAsync("EXEC sp_UpdateTask @Id, @Name", sqlParams);
        return result > 0;
    }


    public async Task<bool> DeleteTaskAsync(int id)
    {
        var idParam = new SqlParameter("@Id", id);
        var result = await _context.Database.ExecuteSqlRawAsync("EXEC sp_DeleteTask @Id", idParam);
        return result > 0;
    }
}