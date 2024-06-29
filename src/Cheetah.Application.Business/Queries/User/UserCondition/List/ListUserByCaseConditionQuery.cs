namespace Cheetah.Application.Business.Queries.User.UserCondition.List;

public record ListUserByCaseConditionQuery(IEnumerable<long?> userFilter, IEnumerable<long?> conditionFilter) : IQuery<Result<IEnumerable<long?>>>;