using Cheetah.UseCases.DTOs.AI;

namespace Cheetah.UseCases.Queries.Case.Case.Get;

public record GetUserGuideQuery(long Id) : IQuery<Result<UserGuideDTO>>;