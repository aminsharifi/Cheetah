using Cheetah.Domain.Common.DTOs;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Domain.Aggregates.CaseAggregate.Specifications;

public class GetDetailCasesSpec : Specification<F_Case>
{
    public GetDetailCasesSpec(SimpleClassDTO request)
    {
        Query
            .AsNoTracking();

        if (request.Id != 0)
        {
            Query
                .Where(x => x.Id == request.Id);
        }

        if (request.ERPCode is not null)
        {
            Query
                .Where(x => x.ERPCode == request.ERPCode);
        }
    }
}