using Cheetah.Core.Aggregates.CaseAggregate.DTOs;
using Cheetah.Core.Common.DTOs;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands;

public class CreateCaseResponse
{
    public CaseDTO? Case { get; set; }
    public BaseClassWithNameDTO? OutputState { get; set; }
}
