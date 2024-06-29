namespace Cheetah.Application.Business.DTOs.Case;

public class CreateCaseRequest
{
    public BaseClassWithDateDTO? Case { get; set; }
    public BaseClassWithNameDTO? Creator { get; set; }
    public BaseClassWithNameDTO? Requestor { get; set; }
    public BaseClassWithNameDTO? Process { get; set; }
    public List<ConditionDTO>? Conditions { get; set; }
    public WorkItemDTO? WorkItem { get; set; }
}