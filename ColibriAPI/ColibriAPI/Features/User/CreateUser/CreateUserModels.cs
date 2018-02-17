using MediatR;
using System;

namespace ColibriAPI.Features.CreateUser
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
}
