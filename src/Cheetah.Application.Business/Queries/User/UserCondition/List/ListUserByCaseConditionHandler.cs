using Cheetah.Domain.Aggregates.UserAggregate.Links;
using Cheetah.Domain.Aggregates.UserAggregate.Specifications;

namespace Cheetah.Application.Business.Queries.User.UserCondition.List;

public class ListUserByCaseConditionHandler(
    IReadRepository<L_UserCondition> _userConditionRepository) : IQueryHandler<ListUserByCaseConditionQuery, Result<IEnumerable<long?>>>
{
    public async Task<Result<IEnumerable<long?>>> Handle(ListUserByCaseConditionQuery request, CancellationToken cancellationToken)
    {
        var _getUserByConditionSpec = new GetUserByCaseConditionSpec(userFilter: request.userFilter, conditionFilter: request.conditionFilter);

        var _userConditions = await _userConditionRepository
            .ListAsync(_getUserByConditionSpec, cancellationToken);


        return _userConditions.ToList();
    }
}