using AutoMapper;
using Models.Entities.TaskAggregate;
using ViewModels.AbTask;

namespace WebApi.Automapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<AbTask, AbTaskViewModel>().ReverseMap();
        }
        
    }
}
