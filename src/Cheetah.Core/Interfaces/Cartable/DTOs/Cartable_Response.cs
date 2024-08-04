using Cheetah.Core.Aggregates.CaseAggregate.DTOs;
using Cheetah.Core.Common.DTOs;

namespace Cheetah.Core.Interfaces.Cartable.DTOs;

public class Cartable_Response
{
    public long? PageNumber { get; set; }
    public long? PageSize { get; set; }
    public long? TotalItems { get; set; }
    public List<CaseDTO>? Cases { get; set; }
    public BaseClassWithNameDTO? OutputState { get; set; }
}
