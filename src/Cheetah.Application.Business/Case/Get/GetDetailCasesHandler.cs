namespace Cheetah.Application.Business.Case.Get;

public class GetDetailCasesHandler(
    IReadRepository<F_Case> caseRepository,
    ISender _ISender) : IQueryHandler<GetDetailCasesQuery, Result<IEnumerable<F_Case>>>
{
    public async Task<Result<IEnumerable<F_Case>>> Handle(GetDetailCasesQuery request, CancellationToken cancellationToken)
    {
        var _GetDetailCaseSpec = new GetDetailCasesSpec(request.input);
        var _case = await caseRepository.ListAsync(_GetDetailCaseSpec, cancellationToken);
        return _case;
    }
}
