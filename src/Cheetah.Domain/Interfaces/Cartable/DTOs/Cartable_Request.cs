using Cheetah.Domain.Common.DTOs;

namespace Cheetah.Domain.Interfaces.Cartable.DTOs;

public class Cartable_Request
{
    public long? PageNumber { get; set; }
    public long? PageSize { get; set; }
    public long? TotalItems { get; set; }
    public BaseClassWithNameDTO? Assignee { get; set; }
    public BaseClassWithNameDTO? CaseState { get; set; }
    public List<BaseClassWithNameDTO>? CaseStateList { get; set; }
    public BaseClassWithNameDTO? Process { get; set; }
    public BaseClassDTO? Case { get; set; }
    public BaseClassDTO? WorkItem { get; set; }
}
