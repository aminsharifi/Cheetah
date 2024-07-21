using Cheetah.Domain.Aggregates.CaseAggregate.Links;
using Cheetah.Domain.Common.DTOs;
using Cheetah.Domain.Common.Specifications;
using Cheetah.Domain.Entities.Dimentions;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Application.Business.Queries.Case.CaseTaskUser.Get;

public class GetCaseTaskUserHandler(IReadRepository<L_CaseTaskUser> _repository,
    IReadRepository<F_Case> _caseRepository,
    IReadRepository<F_Task> _taskRepository,
    IReadRepository<D_User> _userRepository)
  : IQueryHandler<GetCaseTaskUserQuery, Result<L_CaseTaskUser>>
{
    public async Task<Result<L_CaseTaskUser>> Handle(GetCaseTaskUserQuery request, CancellationToken cancellationToken)
    {
        Guard.Against.Null(request.input.Case);
        Guard.Against.Null(request.input.Task);
        Guard.Against.Null(request.input.User);

        long? _firstId = default!, _secondId = default!, _thirdId = default!;

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

        L_CaseTaskUser Return_CaseTaskUser = (L_CaseTaskUser)new L_CaseTaskUser()
            .SetFirstId(_firstId)
            .SetSecondId(_secondId)
            .SetThirdId(_thirdId);

        return Return_CaseTaskUser;

    }
}
