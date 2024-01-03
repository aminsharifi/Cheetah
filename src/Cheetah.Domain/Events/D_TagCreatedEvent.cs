namespace Cheetah.Domain.Events;

public class D_TagCreatedEvent(D_Tag item) : BaseEvent
{
    public D_Tag Item { get; } = item;
}
