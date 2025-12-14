using Cheetah.Core.Aggregates.CaseAggregate.Facts;
using Cheetah.Core.Aggregates.CaseAggregate.Links;
using Cheetah.Core.Aggregates.ProcessAggregate.Facts;
using Cheetah.Core.Aggregates.UserAggregate.Dimentions;
using Cheetah.Core.Common.DTOs;
using Cheetah.Core.Common.Specifications;

namespace Cheetah.UseCases.Queries.Case.CaseTaskUser.Get;

public class GetCaseTaskUserHandler(
    IReadRepository<F_Case> caseRepository,
    IReadRepository<F_Task> taskRepository,
    IReadRepository<D_User> userRepository)
  : IQueryHandler<GetCaseTaskUserQuery, Result<L_CaseTaskUser>>
{
    public async ValueTask<Result<L_CaseTaskUser>> Handle(GetCaseTaskUserQuery request, CancellationToken cancellationToken)
    {
        Guard.Against.Null(request.input.Case);
        Guard.Against.Null(request.input.Task);
        Guard.Against.Null(request.input.User);

        long? _firstId = default!, _secondId = default!, _thirdId = default!;

        #region Case
        var _caseSpec = new GetIdEntitySpec<F_Case>(request.input.Case.Adapt<SimpleClassDTO>());
        _firstId = await caseRepository.FirstOrDefaultAsync(_caseSpec, cancellationToken);
        #endregion

        #region Task
        var _taskSpec = new GetIdEntitySpec<F_Task>(request.input.Task.Adapt<SimpleClassDTO>());
        _secondId = await taskRepository.FirstOrDefaultAsync(_taskSpec, cancellationToken);
        #endregion

        #region User
        var _userSpec = new GetIdEntitySpec<D_User>(request.input.User.Adapt<SimpleClassDTO>());
        _thirdId = await userRepository.FirstOrDefaultAsync(_userSpec, cancellationToken);
        #endregion

        L_CaseTaskUser Return_CaseTaskUser = (L_CaseTaskUser)new L_CaseTaskUser()
            .SetFirstId(_firstId)
            .SetSecondId(_secondId)
            .SetThirdId(_thirdId);

        return Return_CaseTaskUser;

    }
}
