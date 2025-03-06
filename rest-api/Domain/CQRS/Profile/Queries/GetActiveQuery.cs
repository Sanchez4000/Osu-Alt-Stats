using MediatR;

namespace Domain.CQRS.Profile.Queries
{
    public class GetActiveQueryHandler : IRequestHandler<GetActiveQuery, string>
    {
        public async Task<string> Handle(GetActiveQuery request, CancellationToken cancellationToken)
        {
            return "ActiveProfile";
        }
    }

    public class GetActiveQuery : IRequest<string>;
}
