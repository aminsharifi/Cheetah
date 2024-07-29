namespace Cheetah.Domain.Aggregates.CaseAggregate.Links.Specifications;

public class GetByCaseAndTaskSpec : Specification<L_CaseTaskUser>
{
    public GetByCaseAndTaskSpec(long? caseId, long? taskId)
    {
        Query
            .Where(x => x.FirstId == caseId)
            .Where(x => x.SecondId == taskId);

        Query
            .AsNoTracking();

        Query
            .Include(x => x.Case);
    }
}