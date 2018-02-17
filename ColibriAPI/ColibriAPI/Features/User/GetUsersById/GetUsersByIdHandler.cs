using AutoMapper;
using ColibriAPI.DataAccess;
using ColibriAPI.Features.GetUsersById;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ColibriAPI.Features.User.GetUsersById
{
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
                        .Where(x => x.Id == request.Id && !x.IsDeleted)
                        .Single()
                    )
                );
        }
    }
}
