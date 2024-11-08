using Cheetah.Core.Aggregates.AIAggregate.Facts;
using Cheetah.UseCases.DTOs.AI;

namespace Cheetah.UseCases.Queries.Case.Case.Get;

public class ListUserGuidesHandler(
    IReadRepository<F_UserGuide> useruideRepository) : IQueryHandler<ListUserGuidesQuery, Result<IEnumerable<UserGuideDTO>>>
{
    public async Task<Result<IEnumerable<UserGuideDTO>>> Handle(ListUserGuidesQuery request, CancellationToken cancellationToken)
    {
        var _result = await useruideRepository.ListAsync();
        return _result.Select(x => x.Adapt<UserGuideDTO>()).ToList();
    }
}