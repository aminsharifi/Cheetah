using Cheetah.Core.Common.DTOs;
using Cheetah.Core.Common.Specifications;

namespace Cheetah.Core.Aggregates.CaseAggregate.Facts.Specifications;

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