namespace Cheetah.Application.Business.Entity.Specifications;

public class GetEntitySpec<T> : Specification<T> where T : BaseEntity
{
    public GetEntitySpec(long? input)
    {
        Guard.Against.NotFound(nameof(input), "There isn't enough info");
        Query
            .Where(x => x.Id == input);
        Query.EnableCache(nameof(GetEntitySpec<T>), input);
        Query.AsNoTracking();
    }
    public GetEntitySpec(BaseEntity input)
    {
        var Find = false;

        Query
            .EnableCache(nameof(GetEntitySpec<T>), input);

        Query.AsNoTracking();

        if (input.Id > 0)
        {
            Find = true;
            return;
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
            Guard.Against.NotFound(nameof(BaseEntity), "There isn't enough info");
        }
    }
}