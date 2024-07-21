namespace Cheetah.Domain.Common.Specifications;
/// <summary>
/// Recieved all erpcodes
/// </summary>
/// <typeparam name="T">Entity Type</typeparam>
public class GetAllERPCodesSpec<T> : Specification<T, long?> where T : BaseEntity
{
    /// <summary>
    /// Recieved all erpcodes
    /// </summary>
    public GetAllERPCodesSpec()
    {
        Query.AsNoTracking();

        Query.Select(x => x.ERPCode);
    }
}