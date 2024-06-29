namespace Cheetah.Application.Business.Queries.Case.Case.Get;

public static class GetCase
{
    public static async Task<F_Case> Handle(GetCaseQuery request,
        IReadRepository<D_User> _userRepository,
        IReadRepository<D_Process> _processRepository,
        IReadRepository<F_Condition> _conditionRepository,
        CancellationToken cancellationToken)
    {
        #region Validations

        Guard.Against.Null(request.Creator);
        Guard.Against.Null(request.Requestor);
        Guard.Against.Null(request.Process);
        Guard.Against.Null(request.WorkItemUser);
        Guard.Against.Null(request.WorkItemConditions);

        #endregion

        #region Retrive Ids

        long? _eRPCode, _creatorId, _requestorId, _processId;

        _eRPCode = request.Case?.ERPCode;
        var _creatorSpec = new GetIdEntitySpec<D_User>(request.Creator);
        _creatorId = await _userRepository.FirstOrDefaultAsync(_creatorSpec, cancellationToken);

        var _requestorSpec = new GetIdEntitySpec<D_User>(request.Requestor);
        _requestorId = await _userRepository.FirstOrDefaultAsync(_requestorSpec, cancellationToken);

        var _processSpec = new GetIdEntitySpec<D_Process>(request.Process);
        _processId = await _processRepository.FirstOrDefaultAsync(_processSpec, cancellationToken);

        #endregion

        #region Create case        
        F_Case _case =
            (F_Case)new F_Case()
            .SetRequestorId(_requestorId)
            .SetCreatorId(_creatorId)
            .SetProcessId(_processId)
            .SetERPCode(_eRPCode);

        #endregion

        return _case;
    }
}
