namespace Cheetah.Application.Business.UserCondition.Get;

public record GetUserByConditionQuery(IEnumerable<long?> performerConditions) : IQuery<Result<IEnumerable<long?>>>;
