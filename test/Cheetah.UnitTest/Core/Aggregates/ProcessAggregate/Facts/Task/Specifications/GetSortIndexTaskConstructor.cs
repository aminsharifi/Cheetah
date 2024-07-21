using Cheetah.Domain.Aggregates.ProcessAggregate.Facts.Task.Specifications;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.UnitTest.Core.Aggregates.ProcessAggregate.Facts.Task.Specifications;

public class GetSortIndexTaskConstructor
{
    [Fact]
    private void GetSortIndexTask()
    {
        #region Arrange
        F_Task _task1 = F_Task.Sample_Scenario_Requestor;
        F_Task _task2 = F_Task.Sample_Scenario_RequestorManager;
        List<F_Task> _list_Task = new();
        _list_Task.Add(_task1);
        _list_Task.Add(_task2);
        #endregion

        #region Act
        GetSortIndexTask _getSortIndexTask = new(_task1.Id);
        var _filtered = _getSortIndexTask.Evaluate(_list_Task).Single();
        #endregion

        #region Assert
        Assert.Equal(_task1.SortIndex, _filtered);
        #endregion

    }
}
