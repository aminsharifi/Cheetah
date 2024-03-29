namespace Cheetah.Application.Business.Condition.Specifications;

public class GetConditionSpec : Specification<F_Condition>
{
    public GetConditionSpec(long tagId, long operandId, string value)
    {
        Query
            .EnableCache(nameof(GetConditionSpec), tagId + "-" + operandId + "-" + value);

        Query
            .Where(x => x.TagId == tagId)
            .Where(x => x.OperandId == operandId)
            .Where(x => x.Value == value)
            .AsNoTracking();
    }
    public GetConditionSpec(IEnumerable<long> includeId)
    {
        Query
            .EnableCache(nameof(GetConditionSpec), includeId);

        Query
            .Where(x => includeId.Contains(x.Id))
            .AsNoTracking();
    }
}