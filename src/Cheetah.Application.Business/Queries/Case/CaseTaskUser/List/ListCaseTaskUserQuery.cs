using Cheetah.Domain.Aggregates.CaseAggregate.Links;

namespace Cheetah.Application.Business.Queries.Case.CaseTaskUser.List;

public record ListCaseTaskUserQuery(long? caseId, long? taskId) : IQuery<Result<IEnumerable<L_CaseTaskUser>>>;
