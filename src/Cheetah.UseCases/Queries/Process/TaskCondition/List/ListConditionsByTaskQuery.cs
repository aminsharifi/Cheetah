namespace Cheetah.UseCases.Queries.Process.TaskCondition.List;

public record ListConditionsByTaskQuery(long? currentTaskId) : IQuery<Result<IEnumerable<long>>>;