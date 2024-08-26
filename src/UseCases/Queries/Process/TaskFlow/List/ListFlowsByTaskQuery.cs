using Cheetah.Core.Aggregates.ProcessAggregate.Links;

namespace Cheetah.UseCases.Queries.Process.TaskFlow.List;
public record ListFlowsByTaskQuery(long currentTaskId) : IQuery<Result<IEnumerable<L_TaskFlow>>>;