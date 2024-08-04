using Cheetah.Core.Common.DTOs;

namespace Cheetah.Core.Interfaces.WorkItem.DTOs;

public class UpdateWorkItemUser_Response
{
    public BaseClassWithNameDTO? WorkItem { get; set; }
    public BaseClassWithNameDTO? OutputState { get; set; }
}
