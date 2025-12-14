using Cheetah.Core.Aggregates.UserAggregate.Links;
using Cheetah.Core.Aggregates.UserAggregate.Specifications;

namespace Cheetah.UseCases.Queries.User.UserCondition.List;

public class ListUsersByConditionHandler(
    IReadRepository<L_UserCondition> userConditionRepository) : IQueryHandler<ListUsersByConditionQuery, Result<IEnumerable<long>>>
{
    public async ValueTask<Result<IEnumerable<long>>> Handle(ListUsersByConditionQuery request, CancellationToken cancellationToken)
    {
        var _getUserByConditionSpec = new GetUserByConditionSpec(request.performerConditions);

        var _processScenarios = await userConditionRepository
            .ListAsync(_getUserByConditionSpec, cancellationToken);


        return _processScenarios.ToList();
    }
}