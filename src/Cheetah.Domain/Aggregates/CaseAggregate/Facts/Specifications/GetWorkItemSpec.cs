using Cheetah.Domain.Common.DTOs;
using Cheetah.Domain.Common.Specifications;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Domain.Aggregates.CaseAggregate.Facts.Specifications;

public class GetWorkItemSpec : GetEntitySpec<F_WorkItem>
{
    public GetWorkItemSpec(SimpleClassDTO input, bool EnableTrack) : base(input, EnableTrack)
    {
        Query
            .Include(x => x.Case)
            .ThenInclude(x => x.WorkItems);

        Query
            .Include(x => x.WorkItemConditions);
    }
}