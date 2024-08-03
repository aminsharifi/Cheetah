using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Application.Business.Queries.Condition.Get;
public record GetConditionExistsQuery(F_Condition input) : IQuery<Result<bool>>;