namespace Cheetah.Application.Business.Queries.User.UserCondition.List;

public record ListUserByConditionQuery(IEnumerable<long?> performerConditions) : IQuery<Result<IEnumerable<long?>>>;
