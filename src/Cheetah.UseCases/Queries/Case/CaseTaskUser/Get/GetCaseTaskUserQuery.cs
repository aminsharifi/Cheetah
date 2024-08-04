using Cheetah.Core.Aggregates.CaseAggregate.Links;

namespace Cheetah.UseCases.Queries.Case.CaseTaskUser.Get;

public record GetCaseTaskUserQuery(L_CaseTaskUser input) : IQuery<Result<L_CaseTaskUser>>;