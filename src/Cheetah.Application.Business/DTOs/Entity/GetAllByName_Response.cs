namespace Cheetah.Application.Business.DTOs.Entity;

public class GetAllByName_Response
{
    public BaseClassWithNameDTO? TableInput { get; set; }
    public List<BaseClassWithNameDTO>? TableOutput { get; set; } = new();
    public BaseClassWithNameDTO? OutputState { get; set; }
}
