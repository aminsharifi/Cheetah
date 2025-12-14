using Cheetah.Core.Aggregates.ProcessAggregate.Links;
using Cheetah.Core.Aggregates.ProcessAggregate.Links.Specifications;

namespace Cheetah.UseCases.Queries.Process.ProcessScenario.List;

public class ListProcessScenarioHandler(
    IReadRepository<L_ProcessScenario> _processScenarioRepository) : IQueryHandler<ListProcessScenarioQuery, Result<IEnumerable<L_ProcessScenario>>>
{
    public async ValueTask<Result<IEnumerable<L_ProcessScenario>>> Handle(ListProcessScenarioQuery request, CancellationToken cancellationToken)
    {
        var _userSpec = new GetProcessScenarioSpec(request.processId);
        var _processScenarios = await _processScenarioRepository.ListAsync(_userSpec, cancellationToken);

        return _processScenarios;
    }
}
