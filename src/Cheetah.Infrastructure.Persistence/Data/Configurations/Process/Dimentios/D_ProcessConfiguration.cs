using Cheetah.Domain.Entities.Dimentions;
namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Process.Dimentios;

public class D_ProcessConfiguration : IEntityTypeConfiguration<D_Process>
{
    public void Configure(EntityTypeBuilder<D_Process> builder)
    {
        builder.HasComment("The name of the processes that the admin enters");

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
