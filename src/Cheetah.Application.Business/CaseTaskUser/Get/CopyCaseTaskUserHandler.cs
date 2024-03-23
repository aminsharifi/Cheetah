namespace Cheetah.Application.Business.CaseTaskUser.Get;

public class CopyCaseTaskUserHandler(IReadRepository<L_CaseTaskUser> _repository,
    IReadRepository<F_Case> _caseRepository,
    IReadRepository<F_Task> _taskRepository,
    IReadRepository<D_User> _userRepository,
    IMediator _mediator)
  : IQueryHandler<CopyCaseTaskUserQuery, Result<L_CaseTaskUser>>
{
    public async Task<Result<L_CaseTaskUser>> Handle(CopyCaseTaskUserQuery request, CancellationToken cancellationToken)
    {
        Guard.Against.Null<F_Case>(request.input.Case);
        Guard.Against.Null<F_Task>(request.input.Task);
        Guard.Against.Null<D_User>(request.input.User);

        L_CaseTaskUser Return_CaseTaskUser = new();

        #region Case
        var _caseSpec = new GetEntitySpec<F_Case>(request.input.Case);
        Return_CaseTaskUser.FirstId = (await _caseRepository.FirstOrDefaultAsync(_caseSpec, cancellationToken)).Id;
        #endregion

        #region Task
        var _taskSpec = new GetEntitySpec<F_Task>(request.input.Task);
        Return_CaseTaskUser.SecondId = (await _taskRepository.FirstOrDefaultAsync(_taskSpec, cancellationToken)).Id;
        #endregion

        #region User
        var _userSpec = new GetEntitySpec<D_User>(request.input.User);
        Return_CaseTaskUser.ThirdId = (await _userRepository.FirstOrDefaultAsync(_userSpec, cancellationToken)).Id;
        #endregion

        return Return_CaseTaskUser;

    }
}
