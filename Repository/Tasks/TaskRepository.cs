using System.Collections.Generic;
using System.Linq;
using Context;
using Interfaces.Repository;
using Entities.Models.TaskAggregate;

namespace Repository.Tasks
{
    public class TaskRepository : IAbTaskRepository
    {
        private readonly AbOnContext _dbContext;

        public TaskRepository(AbOnContext dbContext)
        {
            _dbContext = dbContext;
        }

        public AbTask AddTask(AbTask abTask)
        {
            _dbContext.Add(abTask);
            _dbContext.SaveChanges();
            return abTask;
        }

        public AbTask UpdateTask(AbTask abTask)
        {
            var entity = _dbContext.AbTask.FirstOrDefault(x => x.UserId == abTask.UserId);
            if (entity == null) return null;
            entity.Category = abTask.Category;
            entity.Description = abTask.Description;
            entity.Difficulty = abTask.Difficulty;
            entity.Name = abTask.Name;
            _dbContext.SaveChanges();
            return entity;

        }

        public void DeleteTask(int id)
        {
            var entity = _dbContext.AbTask.FirstOrDefault(x => x.Id == id);
            if (entity != null) _dbContext.AbTask.Remove(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<AbTask> GetTasks(int ownerId)
        {
            return _dbContext.AbTask.Where(x=> x.UserId == ownerId).ToList();
        }
    }
}
