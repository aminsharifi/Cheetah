namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Facts;

public class F_FlowConfiguration : IEntityTypeConfiguration<F_Flow>
{
    public void Configure(EntityTypeBuilder<F_Flow> builder)
    {
        builder
            .Property(e => e.CaseStateId)
            .HasColumnOrder(101);
    }
}
