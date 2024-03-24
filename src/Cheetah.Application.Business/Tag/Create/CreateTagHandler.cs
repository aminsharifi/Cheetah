namespace Cheetah.Application.Business.Tag.Create;

public class CreateTagHandler(IMediator _mediator, IRepository<D_Tag> _repository)
  : ICommandHandler<CreateTagCommand, Result<long>>
{
    public async Task<Result<long>> Handle(CreateTagCommand request,
      CancellationToken cancellationToken)
    {
        var newContributor = new D_Tag(name: request.Name, displayName: request.DisplayName);

        var createdItem = await _repository.AddAsync(newContributor, cancellationToken);

        var domainEvent = new TagCreatedEvent(createdItem.Id);
        await _mediator.Publish(domainEvent);

        return createdItem.Id;
    }
}

