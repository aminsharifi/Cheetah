using Cheetah.Domain.Entities.Dimentions;
namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Condition.Dimentios;

public class D_TagCategoryConfiguration : IEntityTypeConfiguration<D_TagCategory>
{
    public void Configure(EntityTypeBuilder<D_TagCategory> builder)
    {
        builder.HasComment("Action, Performer");
    }
}
