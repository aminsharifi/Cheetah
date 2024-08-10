using Cheetah.Core.Entities.Facts;

namespace Cheetah.UseCases.Queries.Condition.Get;
public record GetConditionExistsQuery(F_Condition input) : IQuery<Result<bool>>;