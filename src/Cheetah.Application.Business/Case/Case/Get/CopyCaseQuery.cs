namespace Cheetah.Application.Business.Case.Get;

public record CopyCaseQuery(F_Case input) : IQuery<Result<F_Case>>;