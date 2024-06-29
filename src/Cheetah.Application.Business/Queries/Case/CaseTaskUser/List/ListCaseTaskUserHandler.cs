namespace Cheetah.Application.Business.Queries.Case.CaseTaskUser.List;

public class ListCaseTaskUserHandler(IReadRepository<L_CaseTaskUser> _repository)
  : IQueryHandler<ListCaseTaskUserQuery, Result<IEnumerable<L_CaseTaskUser>>>
{
    public async Task<Result<IEnumerable<L_CaseTaskUser>>> Handle(ListCaseTaskUserQuery request, CancellationToken cancellationToken)
    {
        var _caseSpec = new GetByCaseAndTaskSpec(caseId: request.caseId, taskId: request.taskId);
        var _caseTaskUser = await _repository.ListAsync(_caseSpec, cancellationToken);

        return _caseTaskUser;
    }
}
