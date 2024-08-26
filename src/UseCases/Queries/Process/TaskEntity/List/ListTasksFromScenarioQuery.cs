using Cheetah.Core.Aggregates.ProcessAggregate.Facts;

namespace Cheetah.UseCases.Queries.Process.TaskEntity.List;

public record ListTasksFromScenarioQuery(long? input) : IQuery<Result<IEnumerable<F_Task>>>;
