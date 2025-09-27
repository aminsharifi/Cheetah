namespace Cheetah.UseCases.Queries.Case.Case.Get;

public record GetImageQuery(String Name) : IQuery<Result<byte[]>>;