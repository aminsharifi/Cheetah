namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Case.Facts;

public class F_CaseConfiguration : IEntityTypeConfiguration<F_Case>
{
    public void Configure(EntityTypeBuilder<F_Case> builder)
    {
        builder.HasComment("Each request create one record in this table");
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
