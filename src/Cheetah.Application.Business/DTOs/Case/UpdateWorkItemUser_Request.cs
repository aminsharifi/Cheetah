using Cheetah.Domain.Common.DTOs;
namespace Cheetah.Application.Business.DTOs.Case;

public class UpdateWorkItemUser_Request
{
    public BaseClassWithNameDTO? WorkItem { get; set; }
    public BaseClassWithNameDTO? User { get; set; }
}
