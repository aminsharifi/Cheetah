using Cheetah.Application.Business.ProcessScenario.Specifications;
using Cheetah.Domain.Entities.Dimentions;

namespace Cheetah.UnitTest.Core.Aggregates.ProcessAggregate.Specifications;

public class GetProcessSpecConstructor
{
    [Fact]
    private void GetProcess()
    {
        #region Arrange
        D_Process _process1 = new() { Id = 1 };
        D_Process _process2 = new() { Id = 2 };
        D_Process _process3 = new() { Id = 3 };
        List<D_Process> _processList = new List<D_Process>();
        _processList.Add(_process1);
        _processList.Add(_process2);
        _processList.Add(_process3);

        List<D_Process> _selectedProcessList = new List<D_Process>();
        _selectedProcessList.Add(_process1);
        _selectedProcessList.Add(_process2);
        #endregion

        #region Act
        GetProcessSpec _spec = new(_selectedProcessList.Select(x => x.Id));
        var _filtered = _spec.Evaluate(_processList);
        #endregion

        #region Assert
        Assert.Equal(_selectedProcessList, _filtered);
        #endregion
    }
}
