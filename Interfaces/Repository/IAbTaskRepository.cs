using Models.Entities.TaskAggregate;
using System.Collections.Generic;

namespace Interfaces.Repository
{
    public interface IAbTaskRepository
    {
        IEnumerable<AbTask> GetTasks(int ownerId);
        AbTask AddTask(AbTask abTask);
        void UpdateTask(AbTask abTask);
        void DeleteTask(int abTask);
    }
}
