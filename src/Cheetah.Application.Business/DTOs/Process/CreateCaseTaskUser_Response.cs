namespace Cheetah.Application.Business.DTOs.Process;

public class CreateCaseTaskUser_Response
{
    public BaseClassDTO? Case { get; set; }
    public BaseClassWithNameDTO? Task { get; set; }
    public BaseClassWithNameDTO? User { get; set; }
    public BaseClassWithNameDTO? OutputState { get; set; }
}
