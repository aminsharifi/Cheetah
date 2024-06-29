namespace Cheetah.Presentation.Services.WebAPI.Controllers.Commands;

public class CreateCaseTaskUserRequest
{
    public BaseClassDTO? Case { get; set; }
    public BaseClassWithNameDTO? Task { get; set; }
    public BaseClassWithNameDTO? User { get; set; }
}
