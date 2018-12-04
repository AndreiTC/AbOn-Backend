using AutoMapper;
using Interfaces.Mapping;
using Interfaces.Services;
using Models.Entities.TaskAggregate;
using System;
using System.Collections.Generic;
using ViewModels.AbTask;

namespace Maps
{
    public class AbTaskMap : IAbTaskMap
    {
        private readonly IAbTaskService _abTaskService;
        private readonly IMapper _mapper;
        public AbTaskViewModel AddTask(AbTaskViewModel abTaskViewModel)
        {
            var abTask =_mapper.Map<AbTask>(abTaskViewModel);
            return _mapper.Map<AbTaskViewModel>(_abTaskService.AddTask(abTask));

        }

        public void DeleteTask(int abTaskId)
        {
            _abTaskService.DeleteTask(abTaskId);
        }

        public IEnumerable<AbTaskViewModel> GetTasks(int ownerId)
        {
            return _mapper.Map<IEnumerable<AbTaskViewModel>>(_abTaskService.GetTasks(ownerId));
        }

        public void UpdateTask(AbTaskViewModel abTaskViewModel)
        {
            var abTask = _mapper.Map<AbTask>(abTaskViewModel);
            _abTaskService.UpdateTask(abTask);
        }
    }
}
