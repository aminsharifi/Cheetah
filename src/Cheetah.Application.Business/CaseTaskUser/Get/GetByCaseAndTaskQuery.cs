namespace Cheetah.Application.Business.CaseTaskUser.Get;

public record GetByCaseAndTaskQuery(long caseId, long taskId) : IQuery<Result<IEnumerable<L_CaseTaskUser>>>;
