using Cheetah.Domain.Aggregates.UserAggregate.Links;
using Cheetah.Domain.Aggregates.UserAggregate.Specifications;

namespace Cheetah.Application.Business.Queries.User.UserCondition.List;

public class ListUserByConditionHandler(
    IReadRepository<L_UserCondition> _userConditionRepository) : IQueryHandler<ListUserByConditionQuery, Result<IEnumerable<long?>>>
{
    public async Task<Result<IEnumerable<long?>>> Handle(ListUserByConditionQuery request, CancellationToken cancellationToken)
    {
        var _getUserByConditionSpec = new GetUserByConditionSpec(request.performerConditions);

        var _processScenarios = await _userConditionRepository
            .ListAsync(_getUserByConditionSpec, cancellationToken);


        return _processScenarios.ToList();
    }
}