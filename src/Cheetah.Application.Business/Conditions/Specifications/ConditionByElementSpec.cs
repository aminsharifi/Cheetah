namespace Cheetah.Application.Business.Conditions.Specifications;

public class ConditionByElementSpec : Specification<F_Condition>
{
    public ConditionByElementSpec(long tagId, long operandId, string value)
    {
        Query
            .Where(x => x.TagId == tagId)
            .Where(x => x.OperandId == operandId)
            .Where(x => x.Value == value);
    }
}