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
            .HasOne(x=>x.TagType)
            .WithMany()
            .HasForeignKey(e => e.TagTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .Property(e => e.TagCategoryId)
            .HasColumnOrder(101);

        builder
            .HasOne(x=>x.TagCategory)
            .WithMany()
            .HasForeignKey(e => e.TagCategoryId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}