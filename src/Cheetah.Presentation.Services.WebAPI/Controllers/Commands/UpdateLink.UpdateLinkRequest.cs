namespace Cheetah.Presentation.Services.WebAPI.Controllers.Commands;

public class UpdateLinkRequest
{
    public BaseClassWithNameDTO? Base { get; set; }
    public List<SimpleLinkClassDTO>? Records { get; set; }
    public long? Crud { get; set; }
}
