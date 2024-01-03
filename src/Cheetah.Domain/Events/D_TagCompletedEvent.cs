namespace Cheetah.Domain.Events;

public record D_TagCompletedEvent(D_Tag Item) : BaseEvent;