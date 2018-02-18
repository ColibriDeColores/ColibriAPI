using MediatR;
using System;

namespace ColibriAPI.Features.GetUsersById
{
    public class GetUsersByIdModels
    {
        public class Query : IRequest<Result>
        {
            public Guid Id { get; set; }

            public Query(Guid id)
            {
                Id = id;
            }
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
