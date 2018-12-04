using System;
using System.Collections.Generic;
using System.Text;
using ViewModels.AbTask;

namespace Interfaces.Mapping
{
    public interface IAbTaskMap
    {
        IEnumerable<AbTaskViewModel> GetTasks(int ownerId);
        AbTaskViewModel AddTask(AbTaskViewModel abTask);
        void UpdateTask(AbTaskViewModel abTask);
        void DeleteTask(int abTask);
    }
}
