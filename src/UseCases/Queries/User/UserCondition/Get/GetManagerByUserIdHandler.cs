using Cheetah.Core.Aggregates.UserAggregate.Dimentions;
using Cheetah.Core.Aggregates.UserAggregate.Specifications;

namespace Cheetah.UseCases.Queries.User.UserCondition.Get;

public class GetManagerByUserIdHandler(
    IReadRepository<D_User> userRepository) : IQueryHandler<GetManagerByUserIdQuery, Result<long?>>
{
    public async ValueTask<Result<long?>> Handle(GetManagerByUserIdQuery request, CancellationToken cancellationToken)
    {
        var _getUserByConditionSpec = new GetManagerByUserIdSpec(request.userId);

        var _processScenarios = await userRepository
            .FirstOrDefaultAsync(_getUserByConditionSpec, cancellationToken);


        return _processScenarios;
    }
}