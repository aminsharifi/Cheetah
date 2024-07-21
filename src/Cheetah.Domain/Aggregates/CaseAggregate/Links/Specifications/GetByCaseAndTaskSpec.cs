namespace Cheetah.Domain.Aggregates.CaseAggregate.Links.Specifications;

public class GetByCaseAndTaskSpec : Specification<L_CaseTaskUser>
{
    public GetByCaseAndTaskSpec(long? CaseId, long? TaskId)
    {
        Query
            .Where(x => x.FirstId == CaseId)
            .Where(x => x.SecondId == TaskId);

        Query
            .AsNoTracking();

        Query
            .Include(x => x.Case);
    }
}