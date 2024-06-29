namespace Cheetah.Application.Business.DTOs.Case;

public class CreateRequest_Response
{
    public CaseDTO? Case { get; set; }
    public BaseClassWithNameDTO? OutputState { get; set; }
}