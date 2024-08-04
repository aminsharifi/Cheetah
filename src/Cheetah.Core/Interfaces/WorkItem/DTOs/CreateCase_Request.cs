using Cheetah.Core.Aggregates.CaseAggregate.DTOs;
using Cheetah.Core.Aggregates.ConditionAggregate.DTOs;
using Cheetah.Core.Common.DTOs;

namespace Cheetah.Core.Interfaces.WorkItem.DTOs;

public class CreateCase_Request
{
    public BaseClassWithDateDTO? Case { get; set; }
    public BaseClassWithNameDTO? Creator { get; set; }
    public BaseClassWithNameDTO? Requestor { get; set; }
    public BaseClassWithNameDTO? Process { get; set; }
    public List<ConditionDTO>? Conditions { get; set; }
    public WorkItemDTO? WorkItem { get; set; }
}