namespace Cheetah.Application.Business.ProcessScenario.Get;

public class GetProcessScenarioHandler(
    IReadRepository<L_ProcessScenario> _processScenarioRepository) : IQueryHandler<GetProcessScenarioQuery, Result<IEnumerable<L_ProcessScenario>>>
{
    public async Task<Result<IEnumerable<L_ProcessScenario>>> Handle(GetProcessScenarioQuery request, CancellationToken cancellationToken)
    {
        var _userSpec = new GetProcessScenarioSpec(request.processId);
        var _processScenarios = await _processScenarioRepository.ListAsync(_userSpec, cancellationToken);

        return _processScenarios;
    }
}
