using Cheetah.Domain.Common.DTOs;
namespace Cheetah.Domain.Interfaces.WorkItem.DTOs;

public class UpdateWorkItemUser_Request
{
    public BaseClassWithNameDTO? WorkItem { get; set; }
    public BaseClassWithNameDTO? User { get; set; }
}
