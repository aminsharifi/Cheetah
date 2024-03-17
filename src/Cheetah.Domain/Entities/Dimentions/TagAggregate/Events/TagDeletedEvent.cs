namespace Cheetah.Domain.Entities.Dimentions.TagAggregate.Events;

/// <summary>
/// A domain event that is dispatched whenever a contributor is deleted.
/// The DeleteContributorService is used to dispatch this event.
/// </summary>
internal sealed class TagDeletedEvent(long tagId) : DomainEventBase
{
    public long TagId { get; init; } = tagId;
}
