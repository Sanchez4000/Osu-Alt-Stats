using Common.DbModels;
using Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Domain.CQRS.Profile.Queries
{
    public class GetActiveQueryHandler(ApplicationDbContext context) : IRequestHandler<GetActiveQuery, ProfileModel>
    {
        public async Task<ProfileModel?> Handle(GetActiveQuery request, CancellationToken cancellationToken)
        {
            var activeProfile = await context.Profile
                .FirstOrDefaultAsync(x => x.IsActive, cancellationToken);

            return activeProfile;
        }
    }

    public class GetActiveQuery : IRequest<ProfileModel>;
}
