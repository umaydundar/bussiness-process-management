using WebApplication2.Models;

namespace WebApplication2.Interfaces
{
    public interface IUserLogService
    {
        Task<UserLog> GetUserLogAsync(int id);
        Task<bool> InsertUserLogAsync(UserLog task);
        Task<bool> UpdateUserLogAsync(UserLog task);
        Task<bool> DeleteUserLogAsync(int id);
    }
}
