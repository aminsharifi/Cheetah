using Ardalis.Result;
using Cheetah.Domain.Entities.Dimentions.TagAggregate.Events;
using Cheetah.Domain.Interfaces;
using Microsoft.Extensions.Logging;

namespace Cheetah.Domain.Services;

public class DeleteTagService(IRepository<D_Tag> _repository,
  IMediator _mediator,
  ILogger<DeleteTagService> _logger) : IDeleteTagService
{
    public async Task<Result> DeleteTag(long tagId)
    {
        _logger.LogInformation("Deleting Tag {tagId}", tagId);
        var aggregateToDelete = await _repository.GetByIdAsync(tagId);
        if (aggregateToDelete == null) return Result.NotFound();

        await _repository.DeleteAsync(aggregateToDelete);
        var domainEvent = new TagDeletedEvent(tagId);
        await _mediator.Publish(domainEvent);
        return Result.Success();
    }
}