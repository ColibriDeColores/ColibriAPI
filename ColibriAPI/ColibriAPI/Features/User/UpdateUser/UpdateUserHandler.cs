using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ColibriAPI.Features.User.UpdateUser
{
    public class UpdateUserModels
    {
        public class Query : IRequest<Result>
        {
            public Guid Id { get; set; }
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public Guid PasswordSalt { get; set; }
            public DateTime Birthday { get; set; }
            public bool IsAdmin { get; set; }
            public bool IsOrganizer { get; set; }
            public bool IsPlayer { get; set; }
        }

        public class Result
        {
            public bool Success { get; set; }
        }
    }

    public class UpdateUserMappingProfile : Profile
    {
        public UpdateUserMappingProfile()
        {
            CreateMap<CreateUserModels.Query, Models.Entities.User>();
        }
    }

    public class UpdateUserHandler : IRequestHandler<UpdateUserModels.Query, UpdateUserModels.Result>
    {
        public Task<UpdateUserModels.Result> Handle(UpdateUserModels.Query request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new UpdateUserModels.Result() { Success = true });
        }
    }
}
