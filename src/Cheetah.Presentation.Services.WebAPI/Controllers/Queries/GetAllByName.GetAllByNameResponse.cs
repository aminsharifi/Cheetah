namespace Cheetah.Presentation.Services.WebAPI.Controllers.Queries;

public class GetAllByNameResponse
{
    public BaseClassWithNameDTO? TableInput { get; set; }
    public List<BaseClassWithNameDTO>? TableOutput { get; set; } = new();
    public BaseClassWithNameDTO? OutputState { get; set; }
}
