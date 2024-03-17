using Ardalis.Specification;

namespace Cheetah.Domain.Entities.Dimentions.TagAggregate.Specifications;

public class TagByIdSpec : Specification<D_Tag>
{
    public TagByIdSpec(long contributorId)
    {
        Query
            .Where(contributor => contributor.Id == contributorId);
    }
}