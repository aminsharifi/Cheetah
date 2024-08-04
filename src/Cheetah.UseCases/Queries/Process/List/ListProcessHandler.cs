using Cheetah.Core.Aggregates.ProcessAggregate.Specifications;
using Cheetah.Core.Entities.Dimentions;

namespace Cheetah.UseCases.Queries.Process.List;

public class ListProcessHandler(
    IReadRepository<D_Process> processRepository) : IQueryHandler<ListProcessQuery, Result<IEnumerable<D_Process>>>
{
    public async Task<Result<IEnumerable<D_Process>>> Handle(ListProcessQuery request, CancellationToken cancellationToken)
    {
        var _processSpec = new GetProcessSpec(request.processIds);
        var _processes = await processRepository.ListAsync(_processSpec, cancellationToken);

        return _processes;
    }
}
