namespace Cheetah.Application.Business.Case;

public class CreateRequest_Request
{
    public BaseClassWithDateDTO? Case { get; set; }
    public BaseClassWithNameDTO? Creator { get; set; }
    public BaseClassWithNameDTO? Requestor { get; set; }
    public BaseClassWithNameDTO? Process { get; set; }
    public List<ConditionDTO>? Conditions { get; set; }
    public WorkItemDTO? WorkItem { get; set; }
}
