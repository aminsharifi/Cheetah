namespace Cheetah.Application.Business.DTOs.Case;

public class SetCaseTaskUser_Request
{
    public BaseClassDTO? Case { get; set; }
    public BaseClassWithNameDTO? Task { get; set; }
    public BaseClassWithNameDTO? User { get; set; }
}
