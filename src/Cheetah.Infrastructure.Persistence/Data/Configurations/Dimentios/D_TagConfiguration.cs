namespace Cheetah.Infrastructure.Persistence.Data.Configurations;

public class D_TagConfiguration : IEntityTypeConfiguration<D_Tag>
{
    public void Configure(EntityTypeBuilder<D_Tag> builder)
    {
        builder
              .Property(e => e.TagTypeId)
              .HasColumnOrder(100);
    }
}
