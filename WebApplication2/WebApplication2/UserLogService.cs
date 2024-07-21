using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication2.Models;
using Microsoft.Data.SqlClient;

public class UserLogService
{
    private readonly MANAGEMENT_BPMContext _context;

    public UserLogService(MANAGEMENT_BPMContext context)
    {
        _context = context;
    }

    public async Task<UserLog> GetUserLogAsync(int Logid)
    {
        var idParam = new SqlParameter("@LogId", Logid);
        return await _context.UserLogs
                             .FromSqlRaw("EXEC sp_GetUserLog @LogId", idParam)
                             .AsNoTracking()
                             .FirstOrDefaultAsync();
    }

    public async Task<bool> InsertUserLogAsync(UserLog userLog)
    {
        var sqlParams = new SqlParameter[]
        {
            new SqlParameter("@Name", userLog.Name ?? (object)DBNull.Value),
            new SqlParameter("@Email", userLog.Email ?? (object)DBNull.Value),
            new SqlParameter("@Password", userLog.Password ?? (object)DBNull.Value),
            // Add other parameters as needed
        };

        var result = await _context.Database.ExecuteSqlRawAsync("EXEC sp_InsertUserLog @Name, @Email, @Password", sqlParams);
        return result > 0;
    }

    public async Task<bool> UpdateUserLogAsync(UserLog userLog)
    {
        var sqlParams = new SqlParameter[]
        {
            new SqlParameter("@Id", userLog.Id),
            new SqlParameter("@Name", userLog.Name ?? (object)DBNull.Value),
            new SqlParameter("@Email", userLog.Email ?? (object)DBNull.Value),
            new SqlParameter("@Password", userLog.Password ?? (object)DBNull.Value),
            // Add other parameters as needed
        };

        var result = await _context.Database.ExecuteSqlRawAsync("EXEC sp_UpdateUserLog @Id, @Name, @Email, @Password", sqlParams);
        return result > 0;
    }

    public async Task<bool> DeleteUserLogAsync(long id)
    {
        var idParam = new SqlParameter("@Id", id);
        var result = await _context.Database.ExecuteSqlRawAsync("EXEC sp_DeleteUserLog @Id", idParam);
        return result > 0;
    }
}
