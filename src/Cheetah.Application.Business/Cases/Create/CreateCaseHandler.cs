using Ardalis.Result;
using Ardalis.SharedKernel;
using Cheetah.Application.Business.Cases.Create;
using Cheetah.Application.Business.Interfaces;
using Cheetah.Domain.Entities.Dimentions;
using Cheetah.Domain.Entities.Dimentions.TagAggregate.Events;
using MediatR;

namespace Cheetah.Application.Business.Tags.Create;

public class CreateCaseHandler(IMediator _mediator, ICopyClass _iCopyClass,IRepository<D_Tag> _repository)
  : ICommandHandler<CreateCaseCommand, Result<long>>
{
    public async Task<Result<long>> Handle(CreateCaseCommand request,
      CancellationToken cancellationToken)
    {
        //var GeneralRequest = await _iCopyClass.DeepCopy(request);

        var newContributor = new D_Tag(name: request.Name, displayName: request.DisplayName);

        var createdItem = await _repository.AddAsync(newContributor, cancellationToken);

        var domainEvent = new TagCreatedEvent(createdItem.Id);
        await _mediator.Publish(domainEvent);

        return createdItem.Id;
    }
}

