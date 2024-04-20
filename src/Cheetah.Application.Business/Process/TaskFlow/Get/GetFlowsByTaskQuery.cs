namespace Cheetah.Application.Business.TaskFlow.Get;

public record GetFlowsByTaskQuery(long? currentTaskId) : IQuery<Result<IEnumerable<L_TaskFlow>>>;