using AutoMapper;
using ColibriAPI.Models.Entities;

namespace ColibriAPI.Features.CreateUser
{
    public class CreateUserMappingProfile : Profile
    {
        public CreateUserMappingProfile()
        {
            CreateMap<CreateUserModels.Query, User>();
        }
    }
}
