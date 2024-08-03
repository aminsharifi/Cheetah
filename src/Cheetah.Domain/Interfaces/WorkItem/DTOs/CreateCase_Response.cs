using Cheetah.Domain.Aggregates.CaseAggregate.DTOs;
using Cheetah.Domain.Common.DTOs;
namespace Cheetah.Domain.Interfaces.WorkItem.DTOs;

public class CreateCase_Response
{
    public CaseDTO? Case { get; set; }
    public BaseClassWithNameDTO? OutputState { get; set; }
}
