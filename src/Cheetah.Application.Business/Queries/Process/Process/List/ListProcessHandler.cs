namespace Cheetah.Application.Business.Queries.Process.Process.List;

public class ListProcessHandler(
    IReadRepository<D_Process> _processRepository) : IQueryHandler<ListProcessQuery, Result<IEnumerable<D_Process>>>
{
    public async Task<Result<IEnumerable<D_Process>>> Handle(ListProcessQuery request, CancellationToken cancellationToken)
    {
        var _processSpec = new GetProcessSpec(request.processIds);
        var _processes = await _processRepository.ListAsync(_processSpec, cancellationToken);

        return _processes;
    }
}
