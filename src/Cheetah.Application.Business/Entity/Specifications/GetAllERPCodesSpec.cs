namespace Cheetah.Application.Business.Entity.Specifications;
public class GetAllERPCodesSpec<T> : Specification<T, long?> where T : BaseEntity
{
    public GetAllERPCodesSpec()
    {
        Query.AsNoTracking();

        Query.Select(x => x.ERPCode);
    }
}