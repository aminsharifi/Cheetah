namespace Cheetah.Domain.Common.Specifications;
public class GetEntitiesByERPCodeSpec<T> : Specification<T> where T : BaseEntity
{
    public GetEntitiesByERPCodeSpec(IEnumerable<long?> ERPCodes)
    {
        Query.Where(x => ERPCodes.Contains(x.ERPCode));
    }
}