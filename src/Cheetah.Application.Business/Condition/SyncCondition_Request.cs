using Cheetah.Domain.Aggregates.ConditionAggregate.DTOs;

namespace Cheetah.Application.Business.Condition;

public class SyncCondition_Request
{
    public BaseClassWithNameDTO? Base { get; set; }
    public List<ConditionDTO>? Records { get; set; }
    public long? Crud { get; set; }
}
