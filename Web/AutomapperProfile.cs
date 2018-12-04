using AutoMapper;
using Entities.ViewModels.AbTask;
using Entities.Models.TaskAggregate;
using Entities.Models.UserAggregate;
using Entities.ViewModels.User;

namespace WebApi.Automapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<AbTask, AbTaskViewModel>()
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Difficulty, opt => opt.MapFrom(src => src.Difficulty))
                .ForMember(dest => dest.Id,opt=> opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name,opt=> opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.TaskDetails, opt=> opt.MapFrom(src => src.TaskDetails))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ReverseMap();

            CreateMap<Delay, DelayViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Reason, opt => opt.MapFrom(src => src.Reason))
                .ForMember(dest => dest.Solution, opt => opt.MapFrom(src => src.Solution))
                .ForMember(dest => dest.TaskDetailsId, opt => opt.MapFrom(src => src.TaskDetailsId))
                .ForMember(dest => dest.Time, opt => opt.MapFrom(src => src.Time))
                .ReverseMap();

            CreateMap<Difficulty, DifficultyViewModel>()
                .ForMember(dest => dest.DifficultyLevel, opt => opt.MapFrom(src => src.DifficultyLevel))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ReverseMap();

            CreateMap<Step, StepViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.TaskDetailsId, opt => opt.MapFrom(src => src.TaskDetailsId))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ReverseMap();

            CreateMap<TaskDetails, TaskDetailsViewModel>()
                .ForMember(dest => dest.Delays, opt => opt.MapFrom(src => src.Delays))
                .ForMember(dest => dest.Goal, opt => opt.MapFrom(src => src.Goal))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Steps, opt => opt.MapFrom(src => src.Steps))
                .ForMember(dest => dest.TimeFrame, opt => opt.MapFrom(src => src.TimeFrame))
                .ReverseMap();

            CreateMap<User, UserViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.AccountType, opt => opt.MapFrom(src => src.AccountType))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Token, opt => opt.MapFrom(src => src.Token))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
                .ReverseMap();

        }
        
    }
}
