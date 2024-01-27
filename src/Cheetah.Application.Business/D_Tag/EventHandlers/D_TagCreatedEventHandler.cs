namespace Cheetah.Application.Business.D_Tag.EventHandlers;

public class D_TagCreatedEventHandler(ILogger<D_TagCreatedEventHandler> logger) : INotificationHandler<D_TagCreatedEvent>
{
    public Task Handle(D_TagCreatedEvent notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("CleanArchitecture Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
