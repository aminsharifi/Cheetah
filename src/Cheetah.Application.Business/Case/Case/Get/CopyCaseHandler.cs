namespace Cheetah.Application.Business.Case.Get;

public class CopyCaseHandler(
    IReadRepository<D_User> _userRepository,
    IReadRepository<D_Process> _processRepository,
    IReadRepository<F_Condition> _conditionRepository,
    ISender _ISender, IMapper _IMapper) : IQueryHandler<CopyCaseQuery, Result<F_Case>>
{
    public async Task<Result<F_Case>> Handle(CopyCaseQuery request, CancellationToken cancellationToken)
    {
        Guard.Against.Null(request.Creator);
        Guard.Against.Null(request.Requestor);
        Guard.Against.Null(request.Process);
        Guard.Against.Null(request.WorkItemUser);
        Guard.Against.Null(request.WorkItemConditions);


        long? _eRPCode, _creatorId, _requestorId, _processId;

        _eRPCode = request.Case?.ERPCode;

        var _creatorSpec = new GetIdEntitySpec<D_User>(request.Creator);
        _creatorId = await _userRepository.FirstOrDefaultAsync(_creatorSpec, cancellationToken);

        var _requestorSpec = new GetIdEntitySpec<D_User>(request.Requestor);
        _requestorId = await _userRepository.FirstOrDefaultAsync(_requestorSpec, cancellationToken);

        var _processSpec = new GetIdEntitySpec<D_Process>(request.Process);
        _processId = await _processRepository.FirstOrDefaultAsync(_processSpec, cancellationToken);

        var _WorkItemUserSpec = new GetIdEntitySpec<D_User>(request.WorkItemUser);
        var _userId = await _userRepository.FirstOrDefaultAsync(_WorkItemUserSpec, cancellationToken);

        F_Case _case = new(eRPCode: _eRPCode, requestorId: _requestorId, creatorId: _creatorId, processId: _processId);

        F_WorkItem _workItem = new(userId: _userId);

        await Parallel.ForEachAsync(request.WorkItemConditions, async (_condition, _cancellatoin) =>
        {
            var _getCondition = await _ISender.Send(new GetConditionIdQuery(_condition));

            _workItem.WorkItemConditions.Add(new(conditionId: _getCondition.Value));
        });

        if (request.CaseConditions is not null)
        {
            await Parallel.ForEachAsync(request.CaseConditions, async (_condition, _cancellatoin) =>
            {
                var _getCondition = await _conditionRepository
                .FirstOrDefaultAsync(new GetIdEntitySpec<F_Condition>
                (_condition.GetCondition(_IMapper).Adapt<SimpleClassDTO>()));
                _case.CaseConditions.Add(new(conditionId: _getCondition.Value));
            });
        }

        _case.WorkItems.Add(_workItem);

        return _case;
    }
}