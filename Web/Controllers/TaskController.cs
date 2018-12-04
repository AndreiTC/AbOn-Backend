using AutoMapper;
using Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Entities.Models.TaskAggregate;
using System.Collections.Generic;
using Entities.ViewModels.AbTask;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {        
        private readonly IAbTaskService _taskService;
        private readonly IMapper _mapper;
        public TaskController (IAbTaskService taskService,IMapper mapper)
        {
            _taskService = taskService;
            _mapper = mapper;
        }

        [HttpGet("{ownerId}")]
        public IEnumerable<AbTaskViewModel> GetTask(int ownerId)
        {
            IEnumerable<AbTask> toReturn = _taskService.GetTasks(ownerId);
            return _mapper.Map<List<AbTaskViewModel>>(toReturn);
        }

        [HttpPost]
        public AbTaskViewModel AddTask([FromBody] AbTaskViewModel abTask)
        {
            var taskMapped = _mapper.Map<AbTask>(abTask);
            return _mapper.Map<AbTaskViewModel>(_taskService.AddTask(taskMapped));
        }

        [HttpDelete]
        public void DeleteTask(int taskId)
        {
            _taskService.DeleteTask(taskId);
        }
    }
}
