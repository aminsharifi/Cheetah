using Cheetah.Core.Common.DTOs;

namespace Cheetah.Core.Aggregates.ConditionAggregate.DTOs;

public class ConditionDTO
{
    public BaseClassWithNameDTO? Base { get; set; }
    public BaseClassWithNameDTO? Tag { get; set; }
    public BaseClassWithNameDTO? Operand { get; set; }
    public string? Value { get; set; }
    public Boolean ApproveState { get; set; }
}
