namespace Cheetah.Application.Business.Queries.Case.Case.Get;

public class GetCaseHandler(
    IReadRepository<D_User> _userRepository,
    IReadRepository<D_Process> _processRepository,
    IReadRepository<F_Condition> _conditionRepository,
    ISender _ISender, IMapper _IMapper) : IQueryHandler<GetCaseQuery, Result<F_Case>>
{
    public async Task<Result<F_Case>> Handle(GetCaseQuery request, CancellationToken cancellationToken)
    {
        F_Case _case = await GetCase.Handle(request: request, _userRepository: _userRepository,
            _processRepository: _processRepository, _conditionRepository: _conditionRepository,
            cancellationToken: cancellationToken);

        _case = await GetCaseConditions
         .Apply(f_case: _case, caseConditions: request.CaseConditions,
         conditionRepository: _conditionRepository, iMapper: _IMapper,
         cancellationToken: cancellationToken);


        var _workItemUserSpec = new GetIdEntitySpec<D_User>(request.WorkItemUser);
        var _workItemUserId = await _userRepository.FirstOrDefaultAsync(_workItemUserSpec, cancellationToken);

        F_WorkItem _workItem = new F_WorkItem()
            .SetUserId(_workItemUserId);

        _workItem = await GetWorkItem
            .Apply(iSender: _ISender,
            WorkItemUser: request.WorkItemUser, WorkItemBase: request.WorkItemBase,
            workItemConditions: request.WorkItemConditions, _userRepository: _userRepository,
            workItem: _workItem, cancellationToken: cancellationToken);

        //.Apply(iSender: _ISender, workItem: _workItem, cancellationToken: cancellationToken);

        _workItem.SetCase(_case);

        _case.WorkItems.Add(_workItem);

        return _case;
    }
}