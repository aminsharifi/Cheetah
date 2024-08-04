using Cheetah.Core.Aggregates.ProcessAggregate.Links.TaskCondition;
using Cheetah.Core.Aggregates.ProcessAggregate.Links.TaskCondition.Specifications;
using Cheetah.Core.Entities.Facts;

namespace Cheetah.UnitTest.Core.Aggregates.ProcessAggregate.Links.TaskCondition.Specifications;

public class GetConditionsByTaskSpecConstructor
{
    [Fact]
    private void GetConditionsByTask()
    {
        #region Arrange

        F_Condition _condition1 = new() { Id = 1 };
        F_Task _task1 = new() { Id = 1 };
        L_TaskCondition _taskCondition1 = (L_TaskCondition)
            new L_TaskCondition()
            .SetFirstId(_task1.Id)
            .SetSecondId(_condition1.Id);

        F_Condition _condition2 = new() { Id = 2 };
        F_Task _task2 = new() { Id = 2 };
        L_TaskCondition _taskCondition2 = (L_TaskCondition)
            new L_TaskCondition()
            .SetFirstId(_task2.Id)
            .SetSecondId(_condition2.Id);

        List<L_TaskCondition> _listTaskCondition = new();
        _listTaskCondition.Add(_taskCondition1);
        _listTaskCondition.Add(_taskCondition2);
        #endregion

        #region Act
        GetConditionsByTaskSpec _spec = new(CurrentTaskId: _task1.Id);
        var _filtered = _spec.Evaluate(_listTaskCondition);
        #endregion

        #region Assert
        Assert.Multiple(
            () => Assert.Contains(_condition1.Id, _filtered),
            () => Assert.DoesNotContain(_condition2.Id, _filtered));
        #endregion
    }
}
