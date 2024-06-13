using AutoMapper;
using Ispit.API.Models;

namespace Ispit.API.Mapping
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<TodoListBinding, TodoList>();
            CreateMap<TodoList, TodoList>();

        }
    }
}
