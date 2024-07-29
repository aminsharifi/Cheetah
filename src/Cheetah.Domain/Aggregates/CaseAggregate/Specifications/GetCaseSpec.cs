using Cheetah.Domain.Entities.Facts;
using System.Runtime.InteropServices;

namespace Cheetah.Domain.Aggregates.CaseAggregate.Specifications;
public class GetCaseSpec : Specification<F_Case>
{
    public GetCaseSpec([Optional] long? id, [Optional] long? processId, [Optional] long? eRPCode)
    {
        if (id is not null)
        {
            Query
                .Where(x => x.Id == id);
        }
        if (processId is not null)
        {
            Query
                .Where(x => x.ProcessId == processId);
        }
        if (eRPCode is not null)
        {
            Query
                .Where(x => x.ERPCode == eRPCode);
        }

        Query
            .Where(x => x.EnableRecord == true);

        Query
            .Include(x => x.CaseState);

        Query
            .AsNoTracking();
    }
}