namespace Cheetah.Application.Business.Queries.Process.ProcessScenario.List;

public record ListProcessScenarioQuery(long processId) : IQuery<Result<IEnumerable<L_ProcessScenario>>>;