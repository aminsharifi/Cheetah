namespace Cheetah.Application.Business.CaseTaskUser.Get;

public class GetByCaseAndTaskHandler(IReadRepository<L_CaseTaskUser> _repository,
    IMediator _mediator)
  : IQueryHandler<GetByCaseAndTaskQuery, Result<L_CaseTaskUser?>>
{
    public async Task<Result<L_CaseTaskUser?>> Handle(GetByCaseAndTaskQuery request, CancellationToken cancellationToken)
    {
        var _caseSpec = new GetByCaseAndTaskSpec(caseId: request.caseId, taskId: request.taskId);
        var _caseTaskUser = await _repository.FirstOrDefaultAsync(_caseSpec);

        return _caseTaskUser;
    }
}
