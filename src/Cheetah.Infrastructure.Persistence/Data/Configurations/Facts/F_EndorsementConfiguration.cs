namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Facts;

public class F_TaskConfiguration : IEntityTypeConfiguration<F_Task>
{
    public void Configure(EntityTypeBuilder<F_Task> builder)
    {
        builder
         .Property(e => e.ScenarioId)
         .HasColumnOrder(101);

        builder
         .Property(e => e.ConditionId)
         .HasColumnOrder(103);
    }
}
