using Cheetah.Core.Common;

namespace Cheetah.Core.Common.Specifications;
/// <summary>
/// Get Entities with their ERP Codes
/// </summary>
/// <typeparam name="T"></typeparam>
public class GetEntitiesByERPCodeSpec<T> : Specification<T> where T : BaseEntity
{
    /// <summary>
    /// Get Entities with their ERP Codes
    /// </summary>
    /// <param name="ERPCodes">Related ERP codes</param>
    public GetEntitiesByERPCodeSpec(IEnumerable<long?> ERPCodes)
    {
        Query.Where(x => ERPCodes.Contains(x.ERPCode));
    }
}