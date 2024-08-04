using Cheetah.Core.Aggregates.ProcessAggregate.Links.Specifications;
using Cheetah.Core.Entities.Links;

namespace Cheetah.UnitTest.Core.Aggregates.ProcessAggregate.Links.Specifications;

public class GetProcessScenarioConstructor
{
    [Fact]
    private void GetProcessScenario()
    {
        #region Arrange
        L_ProcessScenario _processScenario = L_ProcessScenario.SampleProcess_SampleScenario;
        List<L_ProcessScenario> _listProcessScenario = new();
        _listProcessScenario.Add(_processScenario);
        #endregion

        #region Act
        GetProcessScenarioSpec _spec = new(_processScenario.FirstId!.Value);
        var _filtered = _spec
            .Evaluate(_listProcessScenario)
            .Select(x => x.SecondId);
        #endregion

        #region Assert
        Assert.Contains(_processScenario.SecondId, _filtered);
        #endregion
    }
}
