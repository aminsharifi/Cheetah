namespace Cheetah.Application.Business.Entity.Specifications;

public class GetIdEntitySpec<T> : Specification<T, long?>, ISingleResultSpecification<T> where T : BaseEntity
{
    public GetIdEntitySpec(BaseEntity input)
    {
        var Find = false;
        StringBuilder _keyBulder = new();
        _keyBulder.Append(input.GetType().ToString());

        Query.AsNoTracking();

        if (input.Id > 0)
        {
            Find = true;
            Query.Where(x => x.Id == input.Id);
            _keyBulder.Append(input.Id);
            //return;
        }

        if (!String.IsNullOrEmpty(input.Name))
        {
            Find = true;
            Query.Where(x => x.Name.ToLower() == input.Name.ToLower());
            _keyBulder.Append(input.Name);
        }

        if (input.ERPCode is not null && input.ERPCode!= 0)
        {
            Find = true;
            Query.Where(x => x.ERPCode == input.ERPCode);
            _keyBulder.Append(input.ERPCode);
        }

        if (!Find)
        {
            Guard.Against.NotFound(nameof(BaseEntity), "There isn't enough info");
        }

        Query
            .EnableCache(nameof(GetIdEntitySpec<T>), _keyBulder.ToString());

        Query.Select(x => x.Id);
    }
}