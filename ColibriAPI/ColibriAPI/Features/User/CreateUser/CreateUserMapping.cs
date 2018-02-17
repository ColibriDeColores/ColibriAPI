using AutoMapper;

namespace ColibriAPI.Features.CreateUser
{
    public class CreateUserMappingProfile : Profile
    {
        public CreateUserMappingProfile()
        {
            CreateMap<CreateUserModels.Query, Models.Entities.User>();
        }
    }
}
