namespace Cheetah.Domain.Aggregates.ConditionAggregate.DTOs;

public class ConditionDTO
{
    public BaseClassWithNameDTO? Base { get; set; }
    public BaseClassWithNameDTO? Tag { get; set; }
    public BaseClassWithNameDTO? Operand { get; set; }
    public string? Value { get; set; }
}
