namespace Cheetah.Application.Business.Case.Get;

public class CopyCaseHandler(
    IReadRepository<D_User> _userRepository,
    IReadRepository<D_Process> _processRepository,
    IReadRepository<F_Condition> _conditionRepository,
    ISender _ISender, IMapper _IMapper) : IQueryHandler<CopyCaseQuery, Result<F_Case>>
{
    public async Task<Result<F_Case>> Handle(CopyCaseQuery request, CancellationToken cancellationToken)
    {
        F_Case _case = await CopyCase.Handle(request: request, _userRepository: _userRepository,
            _processRepository: _processRepository, _conditionRepository: _conditionRepository,
            cancellationToken: cancellationToken);

        _case = await CopyCaseConditions
         .Apply(f_case: _case, caseConditions: request.CaseConditions,
         conditionRepository: _conditionRepository, iMapper: _IMapper,
         cancellationToken: cancellationToken);

        F_WorkItem _workItem = await CopyWorkItem
                   .Apply(iSender: _ISender, request: request,
                   _userRepository: _userRepository, cancellationToken: cancellationToken);
        _workItem.SetCase(_case);
        _case.WorkItems.Add(_workItem);

        return _case;
    }
}