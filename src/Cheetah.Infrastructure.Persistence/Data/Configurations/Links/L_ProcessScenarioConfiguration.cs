namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Links;

public class L_ProcessScenarioConfiguration : IEntityTypeConfiguration<L_ProcessScenario>
{
    public void Configure(EntityTypeBuilder<L_ProcessScenario> builder)
    {
        builder
            .HasOne(x => x.Process)
            .WithOne()
            .HasForeignKey<L_ProcessScenario>(x => x.FirstId);

        builder
            .HasOne(x => x.Scenario)
            .WithOne()
            .HasForeignKey<L_ProcessScenario>(x => x.SecondId);
    }
}
