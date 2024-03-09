namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Facts;

public class F_TaskConfiguration : IEntityTypeConfiguration<F_Task>
{
    public void Configure(EntityTypeBuilder<F_Task> builder)
    {
        builder.HasComment("Entities like position, role, etc.");

        builder
         .Property(e => e.ScenarioId)
         .HasColumnOrder(101);
    }
}
