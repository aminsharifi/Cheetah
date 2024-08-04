using Ardalis.SharedKernel;
using Cheetah.Core.Aggregates.ProcessAggregate.Links.Specifications;
using Cheetah.Core.Entities.Dimentions;
using Cheetah.Core.Entities.Facts;
using Cheetah.Core.Entities.Links;
using Cheetah.UseCases.Queries.Process.ProcessScenario.List;
using NSubstitute;

namespace Cheetah.UnitTest.UseCases.Queries.Process.ProcessScenario.List;

public class ListProcessScenarioHandlerHandle
{
    IReadRepository<L_ProcessScenario> _processScenarioRepository;
    D_Process _process;
    F_Scenario _scenario;
    L_ProcessScenario _processScenario;
    List<L_ProcessScenario> _processScenarios;
    ListProcessScenarioQuery _request;
    public ListProcessScenarioHandlerHandle()
    {
        _process = D_Process.SampleProcess;
        _scenario = F_Scenario.SampleScenario;
        _processScenario = new();

        _processScenario
            .SetFirstId(_process.Id)
            .SetSecondId(_scenario.Id);

        _processScenarios = [_processScenario];

        _processScenarioRepository = Substitute.For<IReadRepository<L_ProcessScenario>>();
        _processScenarioRepository
            .ListAsync(Arg.Any<GetProcessScenarioSpec>(), CancellationToken.None)
            .Returns(_processScenarios);
    }

    [Fact]
    public async Task GetProcessScenarios()
    {
        #region Arrange
        _request = new ListProcessScenarioQuery(_process.Id);
        var _handle = new ListProcessScenarioHandler(_processScenarioRepository);
        #endregion

        #region Act
        var _result = await _handle.Handle(_request, CancellationToken.None);
        #endregion

        #region Assert
        Assert.Contains(_processScenario, _result.Value);
        #endregion
    }
}
