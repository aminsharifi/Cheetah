﻿using Cheetah.Application.Business.Queries.Case.WorkItem.Get;
using Cheetah.Domain.Common.Specifications;
using Cheetah.Domain.Entities.Dimentions;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Application.Business.Queries.Case.Case.Get;

public class GetCaseHandler(
    IReadRepository<D_User> userRepository,
    IReadRepository<D_Process> processRepository,
    IReadRepository<F_Condition> conditionRepository,
    ISender iSender, IMapper iMapper) : IQueryHandler<GetCaseQuery, Result<F_Case>>
{
    public async Task<Result<F_Case>> Handle(GetCaseQuery request, CancellationToken cancellationToken)
    {
        F_Case _case = await GetCase.Handle(Request: request, userRepository: userRepository,
            processRepository: processRepository, conditionRepository: conditionRepository,
            cancellationToken: cancellationToken);

        _case = await GetCaseConditions
            .Apply(f_case: _case, caseConditions: request.CaseConditions,
            conditionRepository: conditionRepository, iMapper: iMapper,
            cancellationToken: cancellationToken);


        var _workItemUserSpec = new GetIdEntitySpec<D_User>(request.WorkItemUser);
        var _workItemUserId = await userRepository.FirstOrDefaultAsync(_workItemUserSpec, cancellationToken);

        F_WorkItem _workItem = new F_WorkItem()
            .SetUserId(_workItemUserId);

        _workItem = await GetWorkItem
            .Apply(iSender: iSender,
            WorkItemUser: request.WorkItemUser, WorkItemBase: request.WorkItemBase,
            workItemConditions: request.WorkItemConditions, _userRepository: userRepository,
            workItem: _workItem, cancellationToken: cancellationToken);

        _workItem.SetCase(_case);

        _case?.WorkItems?.Add(_workItem);

        return _case!;
    }
}