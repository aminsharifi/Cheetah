namespace Cheetah.Application.Business.CaseTaskUser.Specifications;

public class GetByCaseAndTaskSpec : Specification<L_CaseTaskUser>
{
    public GetByCaseAndTaskSpec(long? caseId, long? taskId)
    {
        Query
            .Where(x => x.FirstId == caseId)
            .Where(x => x.SecondId == taskId)
            .AsNoTracking()
            .Include(x => x.Case);
    }
}
