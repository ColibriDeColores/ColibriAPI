using AutoMapper;
using ColibriAPI.DataAccess;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ColibriAPI.Features.User.GetUsersById
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

    public class GetUsersByIdMappingProfile : Profile
    {
        public GetUsersByIdMappingProfile()
        {
            CreateMap<Models.Entities.User, GetUsersByIdModels.Result>();
        }
    }

    public class GetUsersByIdHandler : IRequestHandler<GetUsersByIdModels.Query, GetUsersByIdModels.Result>
    {
        private readonly ColibriApiContext _dbContext;

        public GetUsersByIdHandler(ColibriApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<GetUsersByIdModels.Result> Handle(GetUsersByIdModels.Query request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Mapper
                .Map<GetUsersByIdModels.Result>(
                    _dbContext.Set<Models.Entities.User>()
                        .Where(x => x.Id.ToString() == request.Id.ToString()
                            && !x.IsDeleted)
                        .Single()
                    )
                );
        }
    }
}
