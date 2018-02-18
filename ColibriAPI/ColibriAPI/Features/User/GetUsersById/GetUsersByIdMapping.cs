using AutoMapper;

namespace ColibriAPI.Features.GetUsersById
{
    public class GetUsersByIdMappingProfile : Profile
    {
        public GetUsersByIdMappingProfile()
        {
            CreateMap<Models.Entities.User, GetUsersByIdModels.Result>();
        }
    }
}
