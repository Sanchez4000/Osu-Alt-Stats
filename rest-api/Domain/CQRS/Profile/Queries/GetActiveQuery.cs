using Common.ViewModels;
using Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Domain.CQRS.Profile.Queries
{
    public class GetActiveQueryHandler(ApplicationDbContext context) : IRequestHandler<GetActiveQuery, ProfileViewModel>
    {
        public async Task<ProfileViewModel?> Handle(GetActiveQuery request, CancellationToken cancellationToken)
        {
            var activeProfile = await context.Profile
                .Select(x => new ProfileViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    IsActive = x.IsActive,
                })
                .FirstOrDefaultAsync(x => x.IsActive, cancellationToken);

            return activeProfile;
        }
    }

    public class GetActiveQuery : IRequest<ProfileViewModel>;
}
