namespace Cheetah.Application.Business.Condition.Get;
public record CopyConditionQuery(F_Condition input) : IQuery<Result<F_Condition>>;