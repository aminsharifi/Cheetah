using Cheetah.UseCases.DTOs.AI;

namespace Cheetah.UseCases.Queries.Case.Case.Get;

public record ListUserGuidesQuery() : IQuery<Result<IEnumerable<UserGuideDTO>>>;