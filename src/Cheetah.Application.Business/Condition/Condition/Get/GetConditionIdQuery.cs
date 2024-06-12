namespace Cheetah.Application.Business.Condition.Get;
public record GetConditionIdQuery(ConditionDTO input) : IQuery<Result<long?>>;