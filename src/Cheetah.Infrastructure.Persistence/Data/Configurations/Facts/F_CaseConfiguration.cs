using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Facts;

public class F_CaseConfiguration : IEntityTypeConfiguration<F_Case>
{
    public void Configure(EntityTypeBuilder<F_Case> builder)
    {
        builder
            .Property(e => e.RequestorId)
            .HasColumnOrder(106);

        builder
            .Property(e => e.CreatorId)
            .HasColumnOrder(107);

        builder
            .Property(e => e.CaseStateId)
            .HasColumnOrder(110);

        builder
            .Property(e => e.ProcessId)
            .HasColumnOrder(111);

        builder
            .Property(e => e.SelectedScenarioId)
            .HasColumnOrder(113);
    }
}
