using WebApplication2.Models;

namespace WebApplication2.Interfaces
{
    public interface ITaskStepService
    {
        Task<TaskStep> GetTaskStepAsync(int id);
        Task<bool> InsertTaskStepAsync(TaskStep task);
        Task<bool> UpdateTaskStepAsync(TaskStep task);
        Task<bool> DeleteTaskStepAsync(int id);
    }
}
