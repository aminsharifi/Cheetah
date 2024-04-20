namespace Cheetah.Application.Business.UserCondition.Get;

public record GetUserByCaseConditionQuery(IEnumerable<long?> userFilter, IEnumerable<long?> conditionFilter) : IQuery<Result<IEnumerable<long?>>>;