namespace Cheetah.Application.Business.Cases.Get;

public record CopyCaseQuery(F_Case input) : IQuery<Result<F_Case>>;