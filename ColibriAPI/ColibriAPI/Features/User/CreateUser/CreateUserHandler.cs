using AutoMapper;
using FluentValidation;
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
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
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

    public class CreateUserValidator : AbstractValidator<CreateUserModels.Query>
    {
        public CreateUserValidator()
        {
            RuleFor(user => user.FirstName).NotNull();
            RuleFor(user => user.LastName).NotNull();
            RuleFor(user => user.Email).NotNull().EmailAddress();
            RuleFor(user => user.Password).NotNull();
            RuleFor(user => user.Birthday).NotNull();
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
            return Task.FromResult(new CreateUserModels.Result() { Success = true });
        }
    }
}
