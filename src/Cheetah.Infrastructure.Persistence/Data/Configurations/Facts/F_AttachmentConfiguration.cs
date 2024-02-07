namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Facts;

public class F_AttachmentConfiguration : IEntityTypeConfiguration<F_Attachment>
{
    public void Configure(EntityTypeBuilder<F_Attachment> builder)
    {
        builder
            .Property(e => e.Name)
            .HasColumnOrder(100)
            .HasMaxLength(255);

        builder
            .Property(e => e.Data)
            .HasColumnOrder(101);
    }
}
