using Cheetah.Core.Aggregates.CaseAggregate.Links;

namespace Cheetah.UseCases.Queries.Case.CaseTaskUser.List;

public record ListCaseTaskUserQuery(long? caseId, long? taskId) : IQuery<Result<IEnumerable<L_CaseTaskUser>>>;
