using Cheetah.Core.Common.DTOs;

namespace Cheetah.Core.Interfaces.WorkItem.DTOs;

public class UpdateWorkItemUser_Request
{
    public BaseClassWithNameDTO? WorkItem { get; set; }
    public BaseClassWithNameDTO? User { get; set; }
}
