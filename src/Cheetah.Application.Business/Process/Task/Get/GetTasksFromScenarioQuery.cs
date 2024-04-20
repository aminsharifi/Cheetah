namespace Cheetah.Application.Business.Task.Get;

public record GetTasksFromScenarioQuery(long? input) : IQuery<Result<IEnumerable<F_Task>>>;
