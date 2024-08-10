using Cheetah.Core.Entities.Facts;

namespace Cheetah.UseCases.Queries.Condition.List;

public record ListIncludedConditionsQuery(IEnumerable<long> input) : IQuery<Result<IEnumerable<F_Condition>>>;
