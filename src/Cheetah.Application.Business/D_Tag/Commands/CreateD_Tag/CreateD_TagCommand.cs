using Cheetah.Domain.Events;

namespace Cheetah.Application.Business.D_Tag.Commands.CreateD_Tag;

public record CreateD_TagCommand(String? Name, String? DisplayName) : IRequest<Int64>;

public class CreateD_TagCommandCommandHandler(IApplicationDbContext context) : IRequestHandler<CreateD_TagCommand, Int64>
{
    public async Task<Int64> Handle(CreateD_TagCommand request, CancellationToken cancellationToken)
    {
        var entity = new Cheetah.Domain.Entities.Dimentions.D_Tag
        {
            Name = request.Name,
            DisplayName = request.DisplayName
        };

        entity.AddDomainEvent(new D_TagCreatedEvent(entity));

        context.D_Tags.Add(entity);

        await context.SaveChangesAsync(cancellationToken);

        return entity.Id.Value;
    }
}
