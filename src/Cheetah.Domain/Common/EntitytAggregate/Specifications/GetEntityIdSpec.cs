using Ardalis.Specification;

namespace Cheetah.Domain.Entities.Dimentions.TagAggregate.Specifications;

public class GetEntityIdSpec : Specification<BaseEntity>
{
    public GetEntityIdSpec(BaseEntity input)
    {
        Query.AsNoTracking();

        var Find = false;

        if (input.Id > 0)
        {
            Find = true;
            //return input.Id;
        }        

        if (!String.IsNullOrEmpty(input.Name))
        {
            Find = true;
            Query.Where(x => x.Name == input.Name);
        }

        if (input.ERPCode is not null and > 0)
        {
            Find = true;
            Query.Where(x => x.ERPCode == input.ERPCode);
        }

        if (!Find)
        {
            //return 0;
        }
    }
}