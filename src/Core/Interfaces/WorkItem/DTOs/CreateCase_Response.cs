using Cheetah.Core.Aggregates.CaseAggregate.DTOs;
using Cheetah.Core.Common.DTOs;

namespace Cheetah.Core.Interfaces.WorkItem.DTOs;

public class CreateCase_Response
{
    public CaseDTO? Case { get; set; }
    public BaseClassWithNameDTO? OutputState { get; set; }
}
