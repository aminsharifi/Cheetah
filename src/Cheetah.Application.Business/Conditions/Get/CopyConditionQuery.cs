namespace Cheetah.Application.Business.Conditions.Get;
public record CopyConditionQuery(F_Condition input) : IQuery<Result<F_Condition>>;