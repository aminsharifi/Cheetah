using Mapster;

namespace Cheetah.Application.Business.CaseTaskUser.Get;

public class CopyCaseTaskUserHandler(IReadRepository<L_CaseTaskUser> _repository,
    IReadRepository<F_Case> _caseRepository,
    IReadRepository<F_Task> _taskRepository,
    IReadRepository<D_User> _userRepository)
  : IQueryHandler<CopyCaseTaskUserQuery, Result<L_CaseTaskUser>>
{
    public async Task<Result<L_CaseTaskUser>> Handle(CopyCaseTaskUserQuery request, CancellationToken cancellationToken)
    {
        Guard.Against.Null(request.input.Case);
        Guard.Against.Null<F_Task>(request.input.Task);
        Guard.Against.Null<D_User>(request.input.User);

        Int64? _firstId = default!, _secondId = default!, _thirdId = default!;

        #region Case
        var _caseSpec = new GetIdEntitySpec<F_Case>(request.input.Case.Adapt<SimpleClassDTO>());
        _firstId = await _caseRepository.FirstOrDefaultAsync(_caseSpec, cancellationToken);
        #endregion

        #region Task
        var _taskSpec = new GetIdEntitySpec<F_Task>(request.input.Task.Adapt<SimpleClassDTO>());
        _secondId = await _taskRepository.FirstOrDefaultAsync(_taskSpec, cancellationToken);
        #endregion

        #region User
        var _userSpec = new GetIdEntitySpec<D_User>(request.input.User.Adapt<SimpleClassDTO>());
        _thirdId = await _userRepository.FirstOrDefaultAsync(_userSpec, cancellationToken);
        #endregion

        L_CaseTaskUser Return_CaseTaskUser = new(firstId: _firstId, secondId: _secondId, thirdId: _thirdId);

        return Return_CaseTaskUser;

    }
}
