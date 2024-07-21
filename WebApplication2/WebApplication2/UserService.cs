using Microsoft.Data.SqlClient;
using WebApplication2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;


public class UserService
{
    private readonly MANAGEMENTContext _context;

    public UserService(MANAGEMENTContext context)
    {
        _context = context;
    }

    public async Task AddUser(User user)
    {
        var parameters = new[]
        {
            new SqlParameter("@refRole", user.RefRole),
            new SqlParameter("@refJobTitle", user.RefJobTitle),
            new SqlParameter("@Picture", (object)user.Picture ?? DBNull.Value),
            new SqlParameter("@Name", user.Name),
            new SqlParameter("@Email", user.Email),
            new SqlParameter("@Password", user.Password),  // Remember to hash passwords before storage
            new SqlParameter("@Phone", user.Phone),
            new SqlParameter("@GithubUsername", (object)user.GithubUsername ?? DBNull.Value),
            new SqlParameter("@Status", user.Status),
            new SqlParameter("@RecordTime", user.RecordTime),
            new SqlParameter("@StartDateOfWork", (object)user.StartDateOfWork ?? DBNull.Value),
            new SqlParameter("@EndDateOfWork", (object)user.EndDateOfWork ?? DBNull.Value)
        };
        await _context.Database.ExecuteSqlRawAsync("EXEC spAddUser @refRole, @refJobTitle, @Picture, @Name, @Email, @Password, @Phone, @GithubUsername, @Status, @RecordTime, @StartDateOfWork, @EndDateOfWork", parameters);
    }

    public async Task<User> GetUser(long id)
    {
        var idParam = new SqlParameter("@Id", id);
        return await _context.Users.FromSqlRaw("EXEC spGetUser @Id", idParam).FirstOrDefaultAsync();
    }

    public async Task UpdateUser(User user)
    {
        var parameters = new[]
        {
            new SqlParameter("@Id", user.Id),
            new SqlParameter("@Name", user.Name),
            new SqlParameter("@Email", user.Email),
            new SqlParameter("@Phone", user.Phone),
            new SqlParameter("@GithubUsername", (object)user.GithubUsername ?? DBNull.Value),
            new SqlParameter("@Status", user.Status)
        };
        await _context.Database.ExecuteSqlRawAsync("EXEC spUpdateUser @Id, @Name, @Email, @Phone, @GithubUsername, @Status", parameters);
    }

    public async Task DeleteUser(long id)
    {
        var idParam = new SqlParameter("@Id", id);
        await _context.Database.ExecuteSqlRawAsync("EXEC spDeleteUser @Id", idParam);
    }
}
