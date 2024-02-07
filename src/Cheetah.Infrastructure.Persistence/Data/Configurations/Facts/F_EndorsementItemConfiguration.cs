namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Facts;

public class F_ActionConfiguration : IEntityTypeConfiguration<F_Action>
{
    public void Configure(EntityTypeBuilder<F_Action> builder)
    {
        builder
            .Property(e => e.CaseStateId)
            .HasColumnOrder(101);
    }
}
