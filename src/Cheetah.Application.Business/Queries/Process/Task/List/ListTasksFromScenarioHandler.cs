using Cheetah.Domain.Aggregates.ProcessAggregate.Facts.Task.Specifications;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Application.Business.Queries.Process.Task.List;

public class ListTasksFromScenarioHandler(
    IReadRepository<F_Task> _taskRepository) : IQueryHandler<ListTasksFromScenarioQuery, Result<IEnumerable<F_Task>>>
{
    public async Task<Result<IEnumerable<F_Task>>> Handle(ListTasksFromScenarioQuery request, CancellationToken cancellationToken)
    {
        var _tasksFromScenarioSpec = new GetTasksFromScenarioSpec(request.input);

        var _processScenarios = await _taskRepository.ListAsync(_tasksFromScenarioSpec, cancellationToken);

        return _processScenarios;
    }
}