using Cheetah.Presentation.Services.WebAPI.Helper;

namespace Cheetah.Application.Business.Case.Get;

public class CopyCaseHandler(
    IReadRepository<D_User> _userRepository,
    IReadRepository<D_Process> _processRepository,
    IReadRepository<F_Condition> _conditionRepository,
    ISender _ISender) : IQueryHandler<CopyCaseQuery, Result<F_Case>>
{
    public async Task<Result<F_Case>> Handle(CopyCaseQuery request, CancellationToken cancellationToken)
    {
        Guard.Against.Null(request.Creator);
        Guard.Against.Null(request.Requestor);
        Guard.Against.Null(request.Process);
        Guard.Against.Null(request.WorkItemUser);
        Guard.Against.Null(request.WorkItemConditions);

        F_Case _case = new();

        _case.ERPCode = request.Case?.ERPCode;

        var _creatorSpec = new GetIdEntitySpec<D_User>(request.Creator);
        _case.CreatorId = await _userRepository.FirstOrDefaultAsync(_creatorSpec, cancellationToken);

        var _requestorSpec = new GetIdEntitySpec<D_User>(request.Requestor);
        _case.RequestorId = await _userRepository.FirstOrDefaultAsync(_requestorSpec, cancellationToken);

        var _processSpec = new GetIdEntitySpec<D_Process>(request.Process);
        _case.ProcessId = await _processRepository.FirstOrDefaultAsync(_processSpec, cancellationToken);

        F_WorkItem _workItem = new();

        var _WorkItemUserSpec = new GetIdEntitySpec<D_User>(request.WorkItemUser);
        _workItem.UserId = await _userRepository.FirstOrDefaultAsync(_WorkItemUserSpec, cancellationToken);

        await Parallel.ForEachAsync(request.WorkItemConditions, async (_condition, _cancellatoin) =>
        {
            var _getCondition = await _ISender.Send(new GetConditionIdQuery(_condition.GetCondition()));

            _workItem.WorkItemConditions.Add(new()
            {
                SecondId = _getCondition.Value
            });
        });

        await Parallel.ForEachAsync(request.CaseConditions, async (_condition, _cancellatoin) =>
        {
            var _getCondition = await _conditionRepository
            .FirstOrDefaultAsync(new GetIdEntitySpec<F_Condition>(_condition.GetCondition()));
            _case.CaseConditions.Add(new()
            {
                SecondId = _getCondition.Value
            });
        });

        _case.WorkItems.Add(_workItem);

        return _case;
    }
}