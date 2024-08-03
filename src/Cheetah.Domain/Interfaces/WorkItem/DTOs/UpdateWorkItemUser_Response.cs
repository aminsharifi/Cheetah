using Cheetah.Domain.Common.DTOs;
namespace Cheetah.Domain.Interfaces.WorkItem.DTOs;

public class UpdateWorkItemUser_Response
{
    public BaseClassWithNameDTO? WorkItem { get; set; }
    public BaseClassWithNameDTO? OutputState { get; set; }
}
