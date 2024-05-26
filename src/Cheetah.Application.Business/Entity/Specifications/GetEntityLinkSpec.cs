namespace Cheetah.Application.Business.Entity.Specifications;
public class GetEntityLinkSpec<T> : Specification<T, SimpleLinkClassDTO> where T : SimpleLinkClass
{
    public GetEntityLinkSpec()
    {
        Query.AsNoTracking();

        Query.Select(item => new SimpleLinkClassDTO(item.FirstId, item.SecondId));
    }
}