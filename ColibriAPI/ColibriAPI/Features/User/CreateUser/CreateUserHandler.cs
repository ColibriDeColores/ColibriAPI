using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ColibriAPI.Features.User.CreateUser
{
    public class CreateUserModels
    {
        public class Query : IRequest<Result>
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public DateTime Birthday { get; set; }
        }

        public class Result
        {

        }
    }

    public class CreateUserMappingProfile : Profile
    {
        public CreateUserMappingProfile()
        {
            CreateMap<CreateUserModels.Query, Models.Entities.User>();
        }
    }

    public class CreateUserHandler : IRequestHandler<CreateUserModels.Query, CreateUserModels.Result>
    {
        public Task<CreateUserModels.Result> Handle(CreateUserModels.Query request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new CreateUserModels.Result());
        }
    }
}
