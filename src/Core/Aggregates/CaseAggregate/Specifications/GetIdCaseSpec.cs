using Cheetah.Core.Aggregates.CaseAggregate.Dimentions;
using Cheetah.Core.Aggregates.CaseAggregate.Facts;

namespace Cheetah.Core.Aggregates.CaseAggregate.Specifications;
public class GetIdCaseSpec : Specification<F_Case, long?>
{
    public GetIdCaseSpec(long processId, long eRPCode)
    {
        Query
            .Select(x => x.Id);

        Query
            .Where(x => x.ProcessId == processId)
            .Where(x => x.ERPCode == eRPCode)
            .Where(x => x.CaseStateId == D_CaseState.Ongoing.Id || x.CaseStateId == D_CaseState.Editing.Id)
            .Where(x => x.EnableRecord == true);

        Query
            .AsNoTracking();
    }
}