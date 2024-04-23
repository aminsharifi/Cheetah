namespace Cheetah.Application.Business.Condition.Get;
public record IsConditionExistsQuery(F_Condition input) : IQuery<Result<bool>>;