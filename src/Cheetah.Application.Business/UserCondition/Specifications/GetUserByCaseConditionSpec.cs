namespace Cheetah.Application.Business.UserCondition.Specifications;

public class GetUserByCaseConditionSpec : Specification<L_UserCondition, long?>
{
    public GetUserByCaseConditionSpec(IEnumerable<long?> userFilter, IEnumerable<long?> conditionFilter)
    {
        Query
            .Select(x => x.FirstId)
            .Where(x => userFilter.Contains(x.FirstId))
            .Where(x => conditionFilter.Contains(x.SecondId))
            .Where(x => x.EnableRecord)
            .AsNoTracking();
    }
}
