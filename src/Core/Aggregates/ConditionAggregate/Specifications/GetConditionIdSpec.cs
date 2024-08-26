using Cheetah.Core.Aggregates.ConditionAggregate.Facts;

namespace Cheetah.Core.Aggregates.ConditionAggregate.Specifications;

public class GetConditionIdSpec : Specification<F_Condition, long>
{
    public GetConditionIdSpec(long? tagId, long? operandId, string? value)
    {
        Query
            .EnableCache(nameof(GetConditionSpec), tagId + "-" + operandId + "-" + value);

        Query
            .Where(x => x.TagId == tagId)
            .Where(x => x.OperandId == operandId)
            .Where(x => x.Value.ToLower() == value.ToLower());

        Query
            .AsNoTracking();

        Query
            .Select(x => x.Id);
    }
}