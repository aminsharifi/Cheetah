namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Condition.Dimentios;

public class D_TagConfiguration : IEntityTypeConfiguration<D_Tag>
{
    public void Configure(EntityTypeBuilder<D_Tag> builder)
    {
        builder.HasComment("Entities like position, role, etc.");

        builder
              .Property(e => e.TagTypeId)
              .HasColumnOrder(100);
        builder
            .Property(e => e.TagCategoryId)
            .HasColumnOrder(101);
    }
}
