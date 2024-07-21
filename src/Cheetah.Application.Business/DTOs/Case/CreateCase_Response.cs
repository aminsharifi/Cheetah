using Cheetah.Domain.Aggregates.CaseAggregate.DTOs;
using Cheetah.Domain.Common.DTOs;
namespace Cheetah.Application.Business.DTOs.Case;

public class CreateCase_Response
{
    public CaseDTO? Case { get; set; }
    public BaseClassWithNameDTO? OutputState { get; set; }
}
