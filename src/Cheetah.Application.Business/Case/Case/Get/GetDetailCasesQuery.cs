namespace Cheetah.Application.Business.Case.Get;

public record GetDetailCasesQuery(F_Case input) : IQuery<Result<IEnumerable<F_Case>>>;