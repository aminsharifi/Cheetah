namespace Cheetah.Domain.Common.Specifications;
public class GetEntitiesSpec<T> : Specification<T> where T : BaseEntity
{
    public GetEntitiesSpec(IEnumerable<long?> Ids)
    {
        Query.Where(x => Ids.Contains(x.Id));
    }
}