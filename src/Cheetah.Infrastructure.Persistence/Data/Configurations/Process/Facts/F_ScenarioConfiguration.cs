namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Process.Facts;

public class F_ScenarioConfiguration : IEntityTypeConfiguration<F_Scenario>
{
    public void Configure(EntityTypeBuilder<F_Scenario> builder)
    {
        builder
            .HasComment("Scenario of processes");

        builder
            .HasMany(x => x.Tasks)
            .WithOne(x => x.Scenario)
            .HasForeignKey(x => x.ScenarioId);
    }
}