using Cheetah.Domain.Entities.Dimentions;

namespace Cheetah.Infrastructure.Persistence.Data.Configurations;

public class D_EntityConfiguration : IEntityTypeConfiguration<D_Entity>
{
    public void Configure(EntityTypeBuilder<D_Entity> builder)
    {
        builder
         .HasIndex(e => e.Display)
         .IsUnique(false);

        builder
            .Property(e => e.Display)
            .HasDefaultValue(true)
            .HasColumnOrder(100);
    }
}
