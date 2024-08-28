using Cheetah.Core.Common;
using Cheetah.Core.Common.DTOs;

namespace Cheetah.Core.Common.Specifications;

/// <summary>
/// Get id of entity by its properies
/// </summary>
/// <typeparam name="T"></typeparam>
public class GetIdEntitySpec<T> : SingleResultSpecification<T, long> where T : BaseEntity
{
    public GetIdEntitySpec(SimpleClassDTO input)
    {
        var Find = false;
        StringBuilder _keyBulder = new();
        _keyBulder.Append(input.GetType().ToString());

        //Query
        //    .EnableCache(nameof(GetIdEntitySpec<T>), _keyBulder.ToString());

        Query.AsNoTracking();

        if (input.Id > 0)
        {
            Find = true;
            Query.Where(x => x.Id == input.Id);
            _keyBulder.Append(input.Id);
            //return;
        }

        if (!string.IsNullOrEmpty(input.Name))
        {
            Find = true;
            Query.Where(x => x.Name.ToLower() == input.Name.ToLower());
            _keyBulder.Append(input.Name);
        }

        if (input.ERPCode is not null && input.ERPCode != 0)
        {
            Find = true;
            Query.Where(x => x.ERPCode == input.ERPCode);
            _keyBulder.Append(input.ERPCode);
        }

        Query.Select(x => x.Id);
    }
}