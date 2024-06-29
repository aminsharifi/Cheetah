namespace Cheetah.Application.Business.DTOs.Case;

public class UpdateCaseResponse
{
    public CaseDTO? Case { get; set; }
    public BaseClassWithNameDTO? OutputState { get; set; }
}
