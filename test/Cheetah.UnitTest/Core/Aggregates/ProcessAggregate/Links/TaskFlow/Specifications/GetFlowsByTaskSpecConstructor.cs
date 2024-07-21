using Cheetah.Domain.Aggregates.ProcessAggregate.Links.TaskFlow.Specifications;
using Cheetah.Domain.Entities.Links;

namespace Cheetah.UnitTest.Core.Aggregates.ProcessAggregate.Links.TaskFlow.Specifications;

public class GetFlowsByTaskSpecConstructor
{
    [Fact]
    private void GetFlowsByTask()
    {
        #region Arrange
        L_TaskFlow _taskFlow1 = (L_TaskFlow)
            new L_TaskFlow()
            .SetFirstId(1)
            .SetSecondId(1);

        L_TaskFlow _taskFlow2 = (L_TaskFlow)
            new L_TaskFlow()
            .SetFirstId(2)
            .SetSecondId(2);

        List<L_TaskFlow> _listTaskFlow = new();
        _listTaskFlow.Add(_taskFlow1);
        _listTaskFlow.Add(_taskFlow2);

        #endregion

        #region Act
        GetFlowsByTaskSpec _spec = new(CurrentTaskId: 1);
        var _filtered = _spec.Evaluate(_listTaskFlow);
        #endregion

        #region Assert
        Assert.Multiple(
        () => Assert.Contains(_taskFlow1, _filtered),
        () => Assert.DoesNotContain(_taskFlow2, _filtered));
        #endregion
    }
}
