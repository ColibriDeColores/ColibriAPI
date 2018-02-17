﻿using AutoMapper;
using System.Collections.Generic;

namespace ColibriAPI.Features.GetUsers
{
    public class GetUsersMappingProfile : Profile
    {
        public GetUsersMappingProfile()
        {
            CreateMap<Models.Entities.User, GetUsersModels.Result>();
        }
    }
}
