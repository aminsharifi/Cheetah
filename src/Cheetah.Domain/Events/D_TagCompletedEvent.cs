namespace Cheetah.Domain.Events;

public class D_TagCompletedEvent(D_Tag item) : BaseEvent
{
    public D_Tag Item { get; } = item;
}