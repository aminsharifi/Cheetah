namespace Cheetah.Application.Business.DTOs.Case;

public class CreateCaseResponse
{
    public CaseDTO? Case { get; set; }
    public BaseClassWithNameDTO? OutputState { get; set; }
}
