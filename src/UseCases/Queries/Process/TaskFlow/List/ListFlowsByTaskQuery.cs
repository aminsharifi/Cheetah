using Cheetah.Core.Entities.Links;

namespace Cheetah.UseCases.Queries.Process.TaskFlow.List;
public record ListFlowsByTaskQuery(long currentTaskId) : IQuery<Result<IEnumerable<L_TaskFlow>>>;