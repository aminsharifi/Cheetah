namespace Cheetah.Application.Business.Case;

public class SetCaseTaskUser_Response
{
    public BaseClassDTO? Case { get; set; }
    public BaseClassWithNameDTO? Task { get; set; }
    public BaseClassWithNameDTO? User { get; set; }
    public BaseClassWithNameDTO? OutputState { get; set; }
}
