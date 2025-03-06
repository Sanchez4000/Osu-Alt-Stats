using Common.DbModels;
using Data;
using MediatR;

namespace Domain.CQRS.Profile.Commands
{
    public class CreateProfileCommandHandler(ApplicationDbContext context) : IRequestHandler<CreateProfileCommand, Unit>
    {
        public async Task<Unit> Handle(CreateProfileCommand request, CancellationToken cancellationToken)
        {
            await context.Profile.AddAsync(new ProfileModel
            {
                Name = request.Name,
                IsActive = false
            }, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }

    public class CreateProfileCommand : IRequest<Unit>
    {
        public required string Name { get; set; }
    }
}
