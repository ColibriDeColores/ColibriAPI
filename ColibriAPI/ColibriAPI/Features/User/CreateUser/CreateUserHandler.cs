using ColibriAPI.Features.CreateUser;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ColibriAPI.Features.User.CreateUser
{
    public class CreateUserHandler : IRequestHandler<CreateUserModels.Query, CreateUserModels.Result>
    {
        public Task<CreateUserModels.Result> Handle(CreateUserModels.Query request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new CreateUserModels.Result());
        }
    }
}
