using Cheetah.Core.Aggregates.UserAggregate.Links;
using Cheetah.Core.Aggregates.UserAggregate.Specifications;

namespace Cheetah.UseCases.Queries.User.UserCondition.List;

public class ListUsersByCaseConditionHandler(
    IReadRepository<L_UserCondition> userConditionRepository)
    : IQueryHandler<ListUsersByCaseConditionQuery, Result<IEnumerable<long>>>
{
    public async ValueTask<Result<IEnumerable<long>>> Handle(ListUsersByCaseConditionQuery request, CancellationToken cancellationToken)
    {
        var _getUserByConditionSpec = new GetUserByCaseConditionSpec(UserFilter: request.UserFilter, ConditionFilter: request.ConditionFilter);

        var _userConditions = await userConditionRepository
            .ListAsync(_getUserByConditionSpec, cancellationToken);

        return _userConditions.ToList();
    }
}