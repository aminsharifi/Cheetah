using Cheetah.Core.Aggregates.CaseAggregate.Facts;
using Cheetah.Core.Aggregates.UserAggregate.Dimentions;
using Cheetah.Core.Common.DTOs;
using Cheetah.Core.Common.Specifications;
using Cheetah.Core.Interfaces.WorkItem.DTOs;

namespace Cheetah.UseCases.Commands.Case.CaseTaskUser.Create;

public class CreateCaseTaskUserHandler(
    IRepository<D_User> _userRepository,
    IRepository<F_WorkItem> _workItemRepository)
  : ICommandHandler<CreateCaseTaskUserCommand, Result<UpdateWorkItemUser_Response>>
{
    public async Task<Result<UpdateWorkItemUser_Response>> Handle(CreateCaseTaskUserCommand request, CancellationToken cancellationToken)
    {
        Guard.Against.Null(request.input.WorkItem);
        Guard.Against.Null(request.input.User);

        var _workItemSpec = new GetEntitySpec<F_WorkItem>(request.input.WorkItem.Adapt<SimpleClassDTO>(), EnableTrack: true);
        var _workItem = await _workItemRepository.FirstOrDefaultAsync(_workItemSpec);

        Guard.Against.Null(_workItem);
        Guard.Against.Zero(_workItem!.Id);

        var _userIdSpec = new GetIdEntitySpec<D_User>(request.input.User.Adapt<SimpleClassDTO>());
        var _userId = await _userRepository.FirstOrDefaultAsync(_userIdSpec);

        Guard.Against.Zero(_userId);

        _workItem?
            .SetUserId(_userId);

        _workItem?
            .SetDisplayName(request.input.WorkItem.DisplayName);


        await _workItemRepository.UpdateAsync(_workItem!);

        UpdateWorkItemUser_Response _response = new();

        _response.WorkItem = _workItem.Adapt<BaseClassWithNameDTO>();

        _response.OutputState = new BaseClassWithNameDTO { Id = 0 };

        return _response;
    }
}