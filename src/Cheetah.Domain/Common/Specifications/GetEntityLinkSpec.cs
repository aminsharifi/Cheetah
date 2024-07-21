using Cheetah.Domain.Common.DTOs;

namespace Cheetah.Domain.Common.Specifications;
public class GetEntityLinkSpec<T> : Specification<T, SimpleLinkClassDTO> where T : BaseLink
{
    public GetEntityLinkSpec()
    {
        Query.AsNoTracking();

        Query
            .Select(item => item.Adapt<SimpleLinkClassDTO>());
    }
}