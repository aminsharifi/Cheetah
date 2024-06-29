namespace Cheetah.Application.Business.Queries.Condition.Condition.Get;
public record GetConditionExistsQuery(F_Condition input) : IQuery<Result<bool>>;