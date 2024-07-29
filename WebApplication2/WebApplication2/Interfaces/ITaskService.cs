namespace WebApplication2.Interfaces;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

public interface ITaskService
{
    Task<Task> GetTaskAsync(int id);
    Task<bool> InsertTaskAsync(Task task);
    Task<bool> UpdateTaskAsync(Task task);
    Task<bool> DeleteTaskAsync(int id);
}
