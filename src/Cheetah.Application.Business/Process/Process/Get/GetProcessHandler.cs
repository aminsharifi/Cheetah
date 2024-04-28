namespace Cheetah.Application.Business.ProcessScenario.Get;

public class GetProcessHandler(
    IReadRepository<D_Process> _processRepository) : IQueryHandler<GetProcessQuery, Result<IEnumerable<D_Process>>>
{
    public async Task<Result<IEnumerable<D_Process>>> Handle(GetProcessQuery request, CancellationToken cancellationToken)
    {
        var _processSpec = new GetProcessSpec(request.processIds);
        var _processes = await _processRepository.ListAsync(_processSpec, cancellationToken);

        return _processes;
    }
}
