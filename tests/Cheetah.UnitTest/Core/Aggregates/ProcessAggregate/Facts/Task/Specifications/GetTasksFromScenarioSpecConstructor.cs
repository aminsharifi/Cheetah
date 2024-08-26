using Cheetah.Core.Aggregates.ProcessAggregate.Facts;
using Cheetah.Core.Aggregates.ProcessAggregate.Facts.Specifications;

namespace Cheetah.UnitTest.Core.Aggregates.ProcessAggregate.Facts.Task.Specifications;

public class GetTasksFromScenarioSpecConstructor
{
    [Fact]
    private void GetTasksFromScenario()
    {
        #region Arrange
        var _sampleScenario = F_Scenario.SampleScenario;
        F_Task _task1 = F_Task.Sample_Scenario_Requestor;
        F_Task _task2 = F_Task.Sample_Scenario_RequestorManager;
        List<F_Task> _tasks = new List<F_Task>();
        _tasks.Add(_task1);
        _tasks.Add(_task2);
        #endregion

        #region Act
        GetTasksFromScenarioSpec _getTasksFromScenarioSpec = new(_sampleScenario.Id);
        var _filtered = _getTasksFromScenarioSpec.Evaluate(_tasks).ToList();
        #endregion

        #region Assert
        Assert.Equal(_tasks, _filtered);
        #endregion
    }
}
