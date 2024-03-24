namespace Cheetah.Application.Business.ProcessScenario.Get;

public record GetProcessScenarioQuery(long processId) : IQuery<Result<IEnumerable<L_ProcessScenario>>>;