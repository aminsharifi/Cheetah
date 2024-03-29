namespace Cheetah.Application.Business.Task.Get;

public class GetTasksFromScenarioHandler(
    IReadRepository<F_Task> _taskRepository) : IQueryHandler<GetTasksFromScenarioQuery, Result<IEnumerable<F_Task>>>
{
    public async Task<Result<IEnumerable<F_Task>>> Handle(GetTasksFromScenarioQuery request, CancellationToken cancellationToken)
    {
        var _tasksFromScenarioSpec = new GetTasksFromScenarioSpec(request.input);

        var _processScenarios = await _taskRepository.ListAsync(_tasksFromScenarioSpec, cancellationToken);

        return _processScenarios;
    }
}