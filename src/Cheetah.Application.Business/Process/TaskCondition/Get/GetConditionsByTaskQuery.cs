namespace Cheetah.Application.Business.Process.TaskCondition.Get;

public record GetConditionsByTaskQuery(long? currentTaskId) : IQuery<Result<IEnumerable<long>>>;