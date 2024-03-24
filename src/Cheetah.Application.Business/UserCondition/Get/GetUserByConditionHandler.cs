namespace Cheetah.Application.Business.UserCondition.Get;

public class GetUserByConditionHandler(
    IReadRepository<L_UserCondition> _userConditionRepository,
    IMediator _mediator) : IQueryHandler<GetUserByConditionQuery, Result<IEnumerable<long?>>>
{
    public async Task<Result<IEnumerable<long?>>> Handle(GetUserByConditionQuery request, CancellationToken cancellationToken)
    {
        var _getUserByConditionSpec = new GetUserByConditionSpec(request.performerConditions);

        var _processScenarios = (await _userConditionRepository
            .ListAsync(_getUserByConditionSpec, cancellationToken));


        return _processScenarios.ToList();
    }
}