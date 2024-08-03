using Ardalis.SharedKernel;
using Cheetah.Application.Business.Queries.Process.TaskEntity.List;
using Cheetah.Domain.Aggregates.ProcessAggregate.Facts.Task.Specifications;
using Cheetah.Domain.Entities.Facts;
using NSubstitute;

namespace Cheetah.UnitTest.Application.Queries.Process.TaskEntity.List;

public class ListTasksFromScenarioHandlerHandle
{
    IReadRepository<F_Task> taskRepository;
    F_Task _task;
    List<F_Task> _tasks;
    F_Scenario _scenario;
    public ListTasksFromScenarioHandlerHandle()
    {
        _task = F_Task.Sample_Scenario_RequestorManager;
        _tasks = [_task];
        _scenario = F_Scenario.SampleScenario;
        taskRepository = Substitute.For<IReadRepository<F_Task>>();
        taskRepository
            .ListAsync(Arg.Any<GetTasksFromScenarioSpec>(), CancellationToken.None)
            .Returns(_tasks);
    }

    [Fact]
    public async Task GetTasksFromScenario()
    {
        #region Arrange
        ListTasksFromScenarioQuery _request = new(_scenario.Id);
        #endregion

        #region Act
        ListTasksFromScenarioHandler _handle = new ListTasksFromScenarioHandler(taskRepository);
        var _result = await _handle.Handle(_request, CancellationToken.None);
        #endregion

        #region Assert
        Assert.Multiple(
        () => Assert.Single(_result.Value),
        () => Assert.Contains(_task, _result.Value));
        #endregion
    }
}
