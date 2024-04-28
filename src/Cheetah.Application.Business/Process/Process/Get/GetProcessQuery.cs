namespace Cheetah.Application.Business.ProcessScenario.Get;

public record GetProcessQuery(IEnumerable<long?> processIds) : IQuery<Result<IEnumerable<D_Process>>>;