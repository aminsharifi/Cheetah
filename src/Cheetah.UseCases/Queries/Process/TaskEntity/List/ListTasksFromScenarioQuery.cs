using Cheetah.Core.Entities.Facts;

namespace Cheetah.UseCases.Queries.Process.TaskEntity.List;

public record ListTasksFromScenarioQuery(long? input) : IQuery<Result<IEnumerable<F_Task>>>;
