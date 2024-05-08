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
    public GetEntitySpec(BaseEntity input, Boolean? EnableTrack = false)
    {
        var Find = false;

        Query
            .EnableCache(nameof(GetEntitySpec<T>), input);
        if (EnableTrack == false)
        {
            Query.AsNoTracking();
        }
        if (input.Id != 0)
        {
            Find = true;
            Query.Where(x => x.Id == input.Id);
        }

        if (!String.IsNullOrEmpty(input.Name))
        {
            Find = true;
            Query.Where(x => x.Name.ToLower() == input.Name.ToLower());
        }

        if (input.ERPCode is not null && input.ERPCode != 0)
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