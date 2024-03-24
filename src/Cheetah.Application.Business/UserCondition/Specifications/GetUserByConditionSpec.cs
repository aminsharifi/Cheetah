namespace Cheetah.Application.Business.UserCondition.Specifications;

public class GetUserByConditionSpec : Specification<L_UserCondition,long?>
{
    public GetUserByConditionSpec(IEnumerable<long?> performerConditions)
    {
        Query
            .Select(x => x.FirstId)
            .Where(x => performerConditions.Contains(x.SecondId))
            .Where(x => x.EnableRecord)
            .AsNoTracking();
    }
}
