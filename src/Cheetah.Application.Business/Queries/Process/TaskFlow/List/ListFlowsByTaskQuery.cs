namespace Cheetah.Application.Business.Queries.Process.TaskFlow.List;
public record ListFlowsByTaskQuery(long? currentTaskId) : IQuery<Result<IEnumerable<L_TaskFlow>>>;