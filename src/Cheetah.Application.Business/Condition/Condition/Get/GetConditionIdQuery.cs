namespace Cheetah.Application.Business.Condition.Get;
public record GetConditionIdQuery(F_Condition input) : IQuery<Result<long?>>;