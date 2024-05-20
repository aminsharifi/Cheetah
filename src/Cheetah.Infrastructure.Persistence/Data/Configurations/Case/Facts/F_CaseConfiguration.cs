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
            .HasOne<D_User>()
            .WithMany()
            .HasForeignKey(e => e.RequestorId);

        builder
            .Property(e => e.CreatorId)
            .HasColumnOrder(107);

        builder
            .HasOne<D_User>()
            .WithMany()
            .HasForeignKey(e => e.CreatorId);

        builder
            .Property(e => e.CaseStateId)
            .HasColumnOrder(110);

        builder
            .HasOne(x => x.CaseState)
            .WithMany()
            .HasForeignKey(e => e.CaseStateId);

        builder
            .Property(e => e.ProcessId)
            .HasColumnOrder(111);

        builder
            .HasOne<D_Process>()
            .WithMany()
            .HasForeignKey(e => e.ProcessId);

        builder
            .Property(e => e.SelectedScenarioId)
            .HasColumnOrder(113);

        builder
            .HasOne<F_Scenario>()
            .WithMany()
            .HasForeignKey(x => x.SelectedScenarioId);
    }
}
