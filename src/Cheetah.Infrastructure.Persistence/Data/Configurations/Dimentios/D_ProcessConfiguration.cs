namespace Cheetah.Infrastructure.Persistence.Data.Configurations;

public class D_ProcessConfiguration : IEntityTypeConfiguration<D_Process>
{
    public void Configure(EntityTypeBuilder<D_Process> builder)
    {
        builder
           .Property(e => e.ShowSupport)
           .HasDefaultValue(true)
           .HasColumnOrder(110);

        builder
            .Property(e => e.ERP)
            .HasDefaultValue(true)
            .HasColumnOrder(101);

        builder
            .Property(e => e.RemoveRequestorApproval)
            .HasDefaultValue(true)
            .HasColumnOrder(102);
    }
}
