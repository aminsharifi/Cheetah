using Cheetah.Domain.Aggregates.CaseAggregate.DTOs;
using Cheetah.Domain.Aggregates.ConditionAggregate.DTOs;
using Cheetah.Domain.Common.DTOs;

namespace Cheetah.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands;

public class CreateCaseRequest
{
    public const string Route = "/WorkflowEngine/Commands/CreateCase";
    public BaseClassWithDateDTO? Case { get; set; }
    public BaseClassWithNameDTO? Creator { get; set; }
    public BaseClassWithNameDTO? Requestor { get; set; }
    public BaseClassWithNameDTO? Process { get; set; }
    public List<ConditionDTO>? Conditions { get; set; }
    public WorkItemDTO? WorkItem { get; set; }
}