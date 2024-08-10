using Cheetah.Core.Aggregates.CaseAggregate.Links;
using Cheetah.Core.Aggregates.CaseAggregate.Links.Specifications;

namespace Cheetah.UseCases.Queries.Case.CaseTaskUser.List;

public class ListCaseTaskUserHandler(IReadRepository<L_CaseTaskUser> repository)
  : IQueryHandler<ListCaseTaskUserQuery, Result<IEnumerable<L_CaseTaskUser>>>
{
    public async Task<Result<IEnumerable<L_CaseTaskUser>>> Handle(ListCaseTaskUserQuery request, CancellationToken cancellationToken)
    {
        var _caseSpec = new GetByCaseAndTaskSpec(caseId: request.caseId, taskId: request.taskId);
        var _caseTaskUser = await repository.ListAsync(_caseSpec, cancellationToken);

        return _caseTaskUser;
    }
}