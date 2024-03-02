namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Links;

public class L_ProcessScenarioConfiguration : IEntityTypeConfiguration<L_ProcessScenario>
{
    public void Configure(EntityTypeBuilder<L_ProcessScenario> builder)
    {
        builder
            .HasOne(x => x.Process)
            .WithMany(x=>x.ProcessScenarios)
            .HasForeignKey(x => x.FirstId);

        builder
            .HasOne(x => x.Scenario)
            .WithMany(x => x.ProcessScenarios)
            .HasForeignKey(x => x.SecondId);
    }
}
