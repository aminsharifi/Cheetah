namespace Cheetah.Domain.Interfaces;

public interface IDeleteTagService
{
    // This service and method exist to provide a place in which to fire domain events
    // when deleting this aggregate root entity
    public Task<Result> DeleteTag(long tagId);
}
