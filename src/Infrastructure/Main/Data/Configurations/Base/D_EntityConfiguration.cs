using Cheetah.Core.Aggregates.Common.Dimentions;
namespace Cheetah.Infrastructure.Data.Configurations.Base;

public class D_EntityConfiguration : IEntityTypeConfiguration<D_Entity>
{
    public void Configure(EntityTypeBuilder<D_Entity> builder)
    {
        builder.HasComment("Table's name in the Cheetah");

        builder
         .HasIndex(e => e.Display)
         .IsUnique(false);

        builder
            .Property(e => e.Display)
            .HasDefaultValue(true)
            .HasColumnOrder(100);
    }
}
