using Ardalis.Result;
using Ardalis.SharedKernel;
using Cheetah.Domain.Entities.Dimentions;
namespace Cheetah.Application.Business.Tags.Create;

public class CreateTagHandler(IRepository<D_Tag> _repository)
  : ICommandHandler<CreateTagCommand, Result<long>>, ICreateTagHandler
{
    public async Task<Result<long>> Handle(CreateTagCommand request,
      CancellationToken cancellationToken)
    {
        var newContributor = new D_Tag(name: request.Name, displayName: request.DisplayName);

        var createdItem = await _repository.AddAsync(newContributor, cancellationToken);

        return createdItem.Id;
    }
}

