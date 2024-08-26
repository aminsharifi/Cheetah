using Ardalis.SharedKernel;
using Cheetah.Core.Aggregates.ProcessAggregate.Facts;
using Cheetah.Core.Aggregates.ProcessAggregate.Links;
using Cheetah.Core.Aggregates.ProcessAggregate.Links.Specifications;
using Cheetah.UseCases.Queries.Process.TaskFlow.List;
using NSubstitute;

namespace Cheetah.UnitTest.UseCases.Queries.Process.TaskFlow.List;

public class ListFlowsByTaskHandlerHandle
{
    IReadRepository<L_TaskFlow> _taskFlowRepository;
    F_Task _task;
    F_Flow _flow1;
    L_TaskFlow _taskFlow;
    List<L_TaskFlow> _taskFlows;
    public ListFlowsByTaskHandlerHandle()
    {
        _task = F_Task.Sample_Scenario_Requestor;
        _flow1 = new F_Flow() { Id = 1 };
        _taskFlow = new L_TaskFlow() { Id = 1 };
        _taskFlow
            .SetFirstId(_task.Id)
            .SetSecondId(_flow1.Id);
        _taskFlows = [_taskFlow];
        _taskFlowRepository = Substitute.For<IReadRepository<L_TaskFlow>>();

        _taskFlowRepository
            .ListAsync(Arg.Any<GetFlowsByTaskSpec>(), CancellationToken.None)
            .Returns(_taskFlows);
    }
    [Fact]
    public async Task GetFlowsByTask()
    {
        #region Arrange
        ListFlowsByTaskQuery request = new ListFlowsByTaskQuery(_task.Id);
        ListFlowsByTaskHandler _handle = new(_taskFlowRepository);
        #endregion

        #region Act
        var _result = await _handle.Handle(request, CancellationToken.None);
        #endregion

        #region Assert
        Assert.Multiple(
            () => Assert.Equal(_taskFlows, _result.Value),
            () => Assert.Contains(_taskFlow, _result.Value),
            () => Assert.Single(_result.Value));
        #endregion
    }
}
