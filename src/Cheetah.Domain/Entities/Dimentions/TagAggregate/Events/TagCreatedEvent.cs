namespace Cheetah.Domain.Entities.Dimentions.TagAggregate.Events;

public sealed class TagCreatedEvent(long tagId) : DomainEventBase
{
    public long TagId { get; init; } = tagId;
}
