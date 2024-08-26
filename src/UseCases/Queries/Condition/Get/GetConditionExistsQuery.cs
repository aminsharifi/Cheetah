using Cheetah.Core.Aggregates.ConditionAggregate.Facts;

namespace Cheetah.UseCases.Queries.Condition.Get;
public record GetConditionExistsQuery(F_Condition input) : IQuery<Result<bool>>;