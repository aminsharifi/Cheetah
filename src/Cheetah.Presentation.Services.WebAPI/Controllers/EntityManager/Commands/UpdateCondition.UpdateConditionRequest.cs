using Cheetah.Domain.Aggregates.ConditionAggregate.DTOs;
using Cheetah.Domain.Common.DTOs;
namespace Cheetah.Presentation.Services.WebAPI.Controllers.EntityManager.Commands;

public class UpdateConditionRequest
{
    public BaseClassWithNameDTO? Base { get; set; }
    public List<ConditionDTO>? Records { get; set; }
    public long? Crud { get; set; }
}
