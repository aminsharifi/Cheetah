using Cheetah.Core.Common.DTOs;

namespace Cheetah.Presentation.Services.WebAPI.Controllers.EntityManager.Commands;

public class UpdateLinkResponse
{
    public BaseClassWithNameDTO? Result { get; set; }
    public BaseClassWithNameDTO? OutputState { get; set; }
}
