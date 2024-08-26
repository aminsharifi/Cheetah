using Cheetah.Core.Aggregates.ConditionAggregate.Facts;

namespace Cheetah.UseCases.Queries.Condition.List;

public record ListIncludedConditionsQuery(IEnumerable<long> input) : IQuery<Result<IEnumerable<F_Condition>>>;
