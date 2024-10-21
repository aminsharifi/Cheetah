namespace Cheetah.UseCases.Queries.User.UserCondition.Get;

public record GetManagerByUserIdQuery(long userId) : IQuery<Result<long?>>;
