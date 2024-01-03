namespace Cheetah.Domain.Events;

public class D_TagDeletedEvent(D_Tag item) : BaseEvent
{
    public D_Tag Item { get; } = item;
}
