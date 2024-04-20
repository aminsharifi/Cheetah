namespace Cheetah.Application.Business.UserCondition.Get;

public class GetUserByCaseConditionHandler(
    IReadRepository<L_UserCondition> _userConditionRepository) : IQueryHandler<GetUserByCaseConditionQuery, Result<IEnumerable<long?>>>
{
    public async Task<Result<IEnumerable<long?>>> Handle(GetUserByCaseConditionQuery request, CancellationToken cancellationToken)
    {
        var _getUserByConditionSpec = new GetUserByCaseConditionSpec(userFilter: request.userFilter, conditionFilter:request.conditionFilter);

        var _userConditions = (await _userConditionRepository
            .ListAsync(_getUserByConditionSpec, cancellationToken));


        return _userConditions.ToList();
    }
}