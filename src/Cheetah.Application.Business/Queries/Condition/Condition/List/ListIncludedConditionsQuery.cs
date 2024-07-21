using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Application.Business.Queries.Condition.Condition.List;

public record ListIncludedConditionsQuery(IEnumerable<long> input) : IQuery<Result<IEnumerable<F_Condition>>>;
