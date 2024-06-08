namespace Cheetah.Application.Business.Case;

public class GetCase_Request
{
    public BaseClassDTO? Case { get; set; }
    public BaseClassWithNameDTO? CaseState { get; set; }
    public BaseClassWithNameDTO? Process { get; set; }
}
