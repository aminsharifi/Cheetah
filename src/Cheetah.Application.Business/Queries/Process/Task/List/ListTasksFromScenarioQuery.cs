namespace Cheetah.Application.Business.Queries.Process.Task.List;

public record ListTasksFromScenarioQuery(long? input) : IQuery<Result<IEnumerable<F_Task>>>;
