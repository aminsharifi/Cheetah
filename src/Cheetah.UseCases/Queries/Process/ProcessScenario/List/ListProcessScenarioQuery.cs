using Cheetah.Core.Entities.Links;

namespace Cheetah.UseCases.Queries.Process.ProcessScenario.List;

public record ListProcessScenarioQuery(long processId) : IQuery<Result<IEnumerable<L_ProcessScenario>>>;