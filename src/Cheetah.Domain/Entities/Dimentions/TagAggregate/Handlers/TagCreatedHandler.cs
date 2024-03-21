using Cheetah.Domain.Entities.Dimentions.TagAggregate.Events;
using Microsoft.Extensions.Logging;

namespace Cheetah.Domain.Entities.Dimentions.TagAggregate.Handlers;

/// <summary>
/// NOTE: Internal because ContributorDeleted is also marked as internal.
/// </summary>
internal class TagCreatedHandler(ILogger<TagCreatedHandler> logger) : INotificationHandler<TagCreatedEvent>
{
    public async Task Handle(TagCreatedEvent domainEvent, CancellationToken cancellationToken)
    {
        logger.LogInformation("Handling Contributed Deleted event for {contributorId}", domainEvent.TagId);
    }
}

