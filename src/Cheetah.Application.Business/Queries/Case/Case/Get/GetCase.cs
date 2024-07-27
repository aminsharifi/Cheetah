using Cheetah.Domain.Common.Specifications;
using Cheetah.Domain.Entities.Dimentions;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Application.Business.Queries.Case.Case.Get;

public static class GetCase
{
    public static async Task<F_Case> Handle(GetCaseQuery Request,
        IReadRepository<D_User> userRepository,
        IReadRepository<D_Process> processRepository,
        IReadRepository<F_Condition> conditionRepository,
        CancellationToken cancellationToken)
    {
        #region Validations

        Guard.Against.Null(Request.Creator);
        Guard.Against.Null(Request.Requestor);
        Guard.Against.Null(Request.Process);
        Guard.Against.Null(Request.WorkItemUser);
        Guard.Against.Null(Request.WorkItemConditions);

        #endregion

        #region Retrive Ids

        long? _eRPCode, _creatorId, _requestorId, _processId;

        _eRPCode = Request.Case?.ERPCode;
        var _creatorSpec = new GetIdEntitySpec<D_User>(Request.Creator);

        _creatorId = await userRepository.FirstOrDefaultAsync(_creatorSpec, cancellationToken);

        var _requestorSpec = new GetIdEntitySpec<D_User>(Request.Requestor);
        _requestorId = await userRepository.FirstOrDefaultAsync(_requestorSpec, cancellationToken);

        var _processSpec = new GetIdEntitySpec<D_Process>(Request.Process);
        _processId = await processRepository.FirstOrDefaultAsync(_processSpec, cancellationToken);

        #endregion

        #region Create case        
        F_Case _case = new(RequestorId: _requestorId, CreatorId: _creatorId, ProcessId: _processId, ERPCode: _eRPCode);

        #endregion

        return _case;
    }
}
