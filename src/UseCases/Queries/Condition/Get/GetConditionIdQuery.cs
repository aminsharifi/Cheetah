using Cheetah.Core.Aggregates.ConditionAggregate.DTOs;

namespace Cheetah.UseCases.Queries.Condition.Get;
public record GetConditionIdQuery(ConditionDTO input) : IQuery<Result<long>>;