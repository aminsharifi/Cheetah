using Cheetah.Domain.Entities.Dimentions.TagAggregate.Events;
using Microsoft.Extensions.Logging;

namespace Cheetah.Domain.Entities.Dimentions.TagAggregate.Handlers;

/// <summary>
/// NOTE: Internal because TagDeleted is also marked as internal.
/// </summary>
internal class TagDeletedHandler(ILogger<TagDeletedHandler> _logger) : INotificationHandler<TagDeletedEvent>
{
    public async Task Handle(TagDeletedEvent domainEvent, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Handling Tag Deleted event for {TagId}", domainEvent.TagId);

        // TODO: do meaningful work here
        await Task.Delay(1);
    }
}
