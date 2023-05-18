using AutoMapper;
using TM.Application.Features.Tasks.DTOs;
using TM.Domain;

namespace TM.Application.Profiles
{
    public class MappingProfile :Profile
    {

        public MappingProfile()
        {
            CreateMap<Tasks, TasksDto>().ReverseMap();

            CreateMap<Tasks, CreateTasksDto>().ReverseMap();
            CreateMap<Tasks, UpdateTasksDto>().ReverseMap();



            
        }
        
    }
}