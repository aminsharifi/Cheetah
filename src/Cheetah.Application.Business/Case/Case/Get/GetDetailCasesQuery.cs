namespace Cheetah.Application.Business.Case.Get;

public record GetDetailCasesQuery(SimpleClassDTO input) : IQuery<Result<IEnumerable<F_Case>>>;