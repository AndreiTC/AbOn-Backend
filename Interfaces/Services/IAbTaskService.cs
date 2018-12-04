using Models.Entities.TaskAggregate;
using System.Collections.Generic;

namespace Interfaces.Services
{
    public interface IAbTaskService
    {
        IEnumerable<AbTask> GetTasks(int ownerId);
        AbTask AddTask(AbTask abTaskViewModel);
        AbTask UpdateTask(AbTask abTaskViewModel);
        void DeleteTask(int abTaskId);
    }
}
