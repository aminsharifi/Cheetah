namespace Cheetah.Application.Business.Queries.Case.Case.List;

public class ListDetailCasesHandler(
    IReadRepository<F_Case> caseRepository) : IQueryHandler<ListDetailCasesQuery, Result<IEnumerable<F_Case>>>
{
    public async Task<Result<IEnumerable<F_Case>>> Handle(ListDetailCasesQuery request, CancellationToken cancellationToken)
    {
        var _GetDetailCaseSpec = new GetDetailCasesSpec(request.input);
        var _case = await caseRepository.ListAsync(_GetDetailCaseSpec, cancellationToken);
        return _case;
    }
}
