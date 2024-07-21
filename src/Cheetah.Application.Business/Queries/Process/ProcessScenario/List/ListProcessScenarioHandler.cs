using Cheetah.Domain.Aggregates.ProcessAggregate.Links.Specifications;
using Cheetah.Domain.Entities.Links;

namespace Cheetah.Application.Business.Queries.Process.ProcessScenario.List;

public class ListProcessScenarioHandler(
    IReadRepository<L_ProcessScenario> _processScenarioRepository) : IQueryHandler<ListProcessScenarioQuery, Result<IEnumerable<L_ProcessScenario>>>
{
    public async Task<Result<IEnumerable<L_ProcessScenario>>> Handle(ListProcessScenarioQuery request, CancellationToken cancellationToken)
    {
        var _userSpec = new GetProcessScenarioSpec(request.processId);
        var _processScenarios = await _processScenarioRepository.ListAsync(_userSpec, cancellationToken);

        return _processScenarios;
    }
}
