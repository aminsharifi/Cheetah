using Cheetah.Domain.Common.DTOs;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Application.Business.Queries.Case.Case.List;

public record ListDetailCasesQuery(SimpleClassDTO input) : IQuery<Result<IEnumerable<F_Case>>>;