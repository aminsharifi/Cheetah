using Cheetah.Core.Aggregates.CaseAggregate.Facts;
using Cheetah.Core.Aggregates.CaseAggregate.Links;
using Cheetah.Core.Aggregates.ConditionAggregate.Facts;
using Cheetah.Core.Aggregates.ProcessAggregate.Dimentions;
using Cheetah.Core.Aggregates.UserAggregate.Dimentions;
using Cheetah.Core.Common.DTOs;
using Cheetah.Core.Common.Specifications;
using Cheetah.UseCases.Helper;
using Cheetah.UseCases.Queries.Condition.Get;

namespace Cheetah.UseCases.Queries.Case.Case.Get;

public class GetCaseHandler(
    IReadRepository<D_User> userRepository,
    IReadRepository<D_Process> processRepository,
    IReadRepository<F_Condition> conditionRepository,
    ISender iSender, IMapper iMapper) : IQueryHandler<GetCaseQuery, Result<F_Case>>
{
    public async Task<Result<F_Case>> Handle(GetCaseQuery request, CancellationToken cancellationToken)
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
        _creatorId = await userRepository.FirstOrDefaultAsync(_creatorSpec, cancellationToken);
        Guard.Against.Zero(_creatorId.Value);

        var _requestorSpec = new GetIdEntitySpec<D_User>(request.Requestor);
        _requestorId = await userRepository.FirstOrDefaultAsync(_requestorSpec, cancellationToken);
        Guard.Against.Zero(_requestorId.Value);

        var _processSpec = new GetIdEntitySpec<D_Process>(request.Process);
        _processId = await processRepository.FirstOrDefaultAsync(_processSpec, cancellationToken);
        Guard.Against.Zero(_processId.Value);

        #endregion

        F_Case _case = new(RequestorId: _requestorId, CreatorId: _creatorId, ProcessId: _processId, ERPCode: _eRPCode);

        if (request.CaseConditions is not null && request.CaseConditions.Count > 0)
        {
            await Parallel.ForEachAsync(request.CaseConditions, async (_condition, _cancellatoin) =>
            {
                var _getCondition = await conditionRepository
                .FirstOrDefaultAsync(new GetIdEntitySpec<F_Condition>
                (_condition.GetCondition(iMapper).Adapt<SimpleClassDTO>()));
                _case!.CaseConditions!.Add((L_CaseCondition)new L_CaseCondition().SetSecondId(_getCondition));
            });
        }

        var _workItemUserSpec = new GetIdEntitySpec<D_User>(request.WorkItemUser);
        var _workItemUserId = await userRepository.FirstOrDefaultAsync(_workItemUserSpec, cancellationToken);

        F_WorkItem _workItem = (F_WorkItem)new F_WorkItem()
            .SetUserId(_workItemUserId);

        _workItem = request.WorkItemBase is not null ? (F_WorkItem)_workItem
            .SetName(request.WorkItemBase.Name)
            .SetDisplayName(request.WorkItemBase.DisplayName) : _workItem;

        _workItem.WorkItemConditions?.Clear();

        await Parallel.ForEachAsync(request.WorkItemConditions, async (_condition, _cancellatoin) =>
        {
            var _getCondition = await iSender.Send(new GetConditionIdQuery(_condition));

            _workItem.WorkItemConditions?.Add((L_WorkItemCondition)new L_WorkItemCondition().SetSecondId(_getCondition.Value));
        });

        _workItem.SetCase(_case);

        _case?.WorkItems?.Add(_workItem);

        return _case!;
    }
}