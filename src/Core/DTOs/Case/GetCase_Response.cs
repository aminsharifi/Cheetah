using Cheetah.Core.Aggregates.CaseAggregate.DTOs;
using Cheetah.Core.Common.DTOs;

namespace Cheetah.Core.DTOs.Case;

public class GetCase_Response
{
    public CaseDTO? Case { get; set; }
    public BaseClassWithNameDTO? OutputState { get; set; }
}
