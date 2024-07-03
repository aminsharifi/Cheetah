using Cheetah.Application.Business.DTOs.Process;

namespace Cheetah.Application.Business.Commands.Case.CaseTaskUser.Create;

public class CreateCaseTaskUserHandler(
    IRepository<F_Case> _caseRepository,
    IRepository<F_Task> _taskRepository,
    IRepository<D_User> _userRepository,
    IRepository<F_WorkItem> _workItemRepository,
    IRepository<L_CaseTaskUser> _caseTaskUserRepository)
  : ICommandHandler<CreateCaseTaskUserCommand, Result<CreateCaseTaskUser_Response>>
{
    public async Task<Result<CreateCaseTaskUser_Response>> Handle(CreateCaseTaskUserCommand request, CancellationToken cancellationToken)
    {
        Guard.Against.Null(request.input.Case);
        Guard.Against.Null(request.input.Task);
        Guard.Against.Null(request.input.User);

        var _caseIdSpec = new GetIdEntitySpec<F_Case>(request.input.Case.Adapt<SimpleClassDTO>());
        var _caseId = await _caseRepository.FirstOrDefaultAsync(_caseIdSpec);
        var _taskIdSpec = new GetIdEntitySpec<F_Task>(request.input.Task.Adapt<SimpleClassDTO>());
        var _taskId = await _taskRepository.FirstOrDefaultAsync(_taskIdSpec);
        var _userIdSpec = new GetIdEntitySpec<D_User>(request.input.User.Adapt<SimpleClassDTO>());
        var _userId = await _userRepository.FirstOrDefaultAsync(_userIdSpec);

        var _caseTaskUser = (L_CaseTaskUser) new L_CaseTaskUser()
        .SetFirstId(_caseId.Value)
        .SetSecondId(_taskId.Value)
        .SetThirdId(_userId.Value);

        //var _addedCaseTaskUser = await _caseTaskUserRepository.AddAsync(_caseTaskUser, cancellationToken);

        var _getWorkItemByCaseTaskUserSpec =
            new GetWorkItemByCaseTaskUserSpec(CaseId: _caseId, taskId: _taskId);

        var _workItems = await _workItemRepository.ListAsync(_getWorkItemByCaseTaskUserSpec);

        foreach (var _workItem in _workItems)
        {
            _workItem
                .SetUserId(_userId);

            _workItem
                .SetDescription("Changed manually");
        }

        await _workItemRepository.UpdateRangeAsync(_workItems);

        CreateCaseTaskUser_Response _response = new();

        _response.Case = new BaseClassDTO() { Id = _caseId.Value };
        _response.Task = new BaseClassWithNameDTO() { Id = _taskId.Value };
        _response.User = new BaseClassWithNameDTO() { Id = _userId.Value };
        _response.OutputState = new BaseClassWithNameDTO { Id = 0 };

        return _response;
    }
}