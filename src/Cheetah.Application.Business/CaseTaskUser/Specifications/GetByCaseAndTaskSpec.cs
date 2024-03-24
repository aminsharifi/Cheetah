namespace Cheetah.Application.Business.CaseTaskUser.Specifications;

public class GetByCaseAndTaskSpec : Specification<L_CaseTaskUser>
{
    public GetByCaseAndTaskSpec(long caseId, long taskId)
    {
        Query
            .Where(x => x.Case.Id == caseId)
            .Where(x => x.Task.Id == taskId)
            .AsNoTracking()
            .Include(x => x.Case)
            .Include(x => x.Task)
            .Include(x => x.User);
    }
}
