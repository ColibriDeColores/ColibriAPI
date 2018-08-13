using AutoMapper;
using ColibriAPI.DataAccess;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ColibriAPI.Features.User.GetUsers
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

    public class GetUsersMappingProfile : Profile
    {
        public GetUsersMappingProfile()
        {
            CreateMap<Models.Entities.User, GetUsersModels.Result>();
        }
    }

    public class GetUsersHandler : IRequestHandler<GetUsersModels.Query, List<GetUsersModels.Result>>
    {
        private readonly ColibriApiContext _dbContext;

        public GetUsersHandler(ColibriApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<GetUsersModels.Result>> Handle(GetUsersModels.Query request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Mapper
                .Map<List<GetUsersModels.Result>>(
                    _dbContext.Set<Models.Entities.User>()
                        .Where(x => !x.IsDeleted)
                        .ToList()
                    )
                );
        }
    }
}
