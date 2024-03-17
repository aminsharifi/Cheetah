using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Cheetah.Application.Business.Tags.Create;

public class CreateContributorHandler(IRepository<D_Tag> _repository)
  : ICommandHandler<CreateTagCommand, Result<long>>
{
    public async Task<Result<long>> Handle(CreateTagCommand request,
      CancellationToken cancellationToken)
    {
        var newContributor = new D_Tag(name: request.Name, displayName: request.DisplayName);
        //if (!string.IsNullOrEmpty(request.Name))
        //{
        //    newContributor.SetPhoneNumber(request.PhoneNumber);
        //}
        var createdItem = await _repository.AddAsync(newContributor, cancellationToken);

        return createdItem.Id;
    }
}