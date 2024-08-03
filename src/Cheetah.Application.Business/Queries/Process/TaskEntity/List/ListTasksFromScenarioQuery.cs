using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Application.Business.Queries.Process.TaskEntity.List;

public record ListTasksFromScenarioQuery(long? input) : IQuery<Result<IEnumerable<F_Task>>>;
