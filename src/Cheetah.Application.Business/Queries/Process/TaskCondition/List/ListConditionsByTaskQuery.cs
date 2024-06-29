namespace Cheetah.Application.Business.Queries.Process.TaskCondition.List;

public record ListConditionsByTaskQuery(long? currentTaskId) : IQuery<Result<IEnumerable<long>>>;