using MediatR;
using System;
using System.Collections.Generic;

namespace ColibriAPI.Features.GetUsers
{
    public class GetUsersModels
    {
        public class Query : IRequest<List<Result>>
        {
        }

        public class Result
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public DateTime Birthday { get; set; }
        }
    }
}
