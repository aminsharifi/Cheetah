using Cheetah.Domain.Aggregates.CaseAggregate.DTOs;
using Cheetah.Domain.Common.DTOs;
namespace Cheetah.Application.Business.DTOs.Case;

public class Cartable_Response
{
    public long? PageNumber { get; set; }
    public long? PageSize { get; set; }
    public long? TotalItems { get; set; }
    public List<CaseDTO>? Cases { get; set; }
    public BaseClassWithNameDTO? OutputState { get; set; }
}
