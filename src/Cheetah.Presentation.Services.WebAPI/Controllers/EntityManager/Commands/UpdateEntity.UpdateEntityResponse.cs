using Cheetah.Core.Common.DTOs;

namespace Cheetah.Presentation.Services.WebAPI.Controllers.EntityManager.Commands;

public class UpdateEntityResponse
{
    public BaseClassWithNameDTO? Result { get; set; }
    public BaseClassWithNameDTO? OutputState { get; set; }
}
