using System.Collections.Generic;
using Interfaces.Repository;
using Interfaces.Services;
using Entities.Models.TaskAggregate;

namespace Services.Task
{
    public class AbTaskService : IAbTaskService
    {
        private readonly IAbTaskRepository _abTaskRepository;
        public AbTaskService(IAbTaskRepository abTaskRepository)
        {
            _abTaskRepository = abTaskRepository;
        }

        public AbTask AddTask(AbTask abTask)
        {
            return _abTaskRepository.AddTask(abTask);
        }

        public void DeleteTask(int abTask)
        {
            _abTaskRepository.DeleteTask(abTask);
        }

        public IEnumerable<AbTask> GetTasks(int ownerId)
        {
            return _abTaskRepository.GetTasks(ownerId);
        }

        public AbTask UpdateTask(AbTask abTask)
        {
            return _abTaskRepository.UpdateTask(abTask);
        }
    }
}
