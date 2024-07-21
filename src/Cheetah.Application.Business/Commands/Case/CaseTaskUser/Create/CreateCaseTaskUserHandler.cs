using Cheetah.Application.Business.DTOs.Case;
using Cheetah.Domain.Aggregates.CaseAggregate.Links;
using Cheetah.Domain.Common.DTOs;
using Cheetah.Domain.Common.Specifications;
using Cheetah.Domain.Entities.Dimentions;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Application.Business.Commands.Case.CaseTaskUser.Create;

public class CreateCaseTaskUserHandler(
    IRepository<F_Task> _taskRepository,
    IRepository<D_User> _userRepository,
    IRepository<F_WorkItem> _workItemRepository,
    IRepository<L_CaseTaskUser> _caseTaskUserRepository)
  : ICommandHandler<CreateCaseTaskUserCommand, Result<UpdateWorkItemUser_Response>>
{
    public async Task<Result<UpdateWorkItemUser_Response>> Handle(CreateCaseTaskUserCommand request, CancellationToken cancellationToken)
    {
        Guard.Against.Null(request.input.WorkItem);
        Guard.Against.Null(request.input.User);

        var _workItemSpec = new GetEntitySpec<F_WorkItem>(request.input.WorkItem.Adapt<SimpleClassDTO>(), EnableTrack: true);
        var _workItem = await _workItemRepository.FirstOrDefaultAsync(_workItemSpec);

        var _userIdSpec = new GetIdEntitySpec<D_User>(request.input.User.Adapt<SimpleClassDTO>());
        var _userId = await _userRepository.FirstOrDefaultAsync(_userIdSpec);

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