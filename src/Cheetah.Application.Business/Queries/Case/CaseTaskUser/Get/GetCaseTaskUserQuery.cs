using Cheetah.Domain.Aggregates.CaseAggregate.Links;

namespace Cheetah.Application.Business.Queries.Case.CaseTaskUser.Get;

public record GetCaseTaskUserQuery(L_CaseTaskUser input) : IQuery<Result<L_CaseTaskUser>>;