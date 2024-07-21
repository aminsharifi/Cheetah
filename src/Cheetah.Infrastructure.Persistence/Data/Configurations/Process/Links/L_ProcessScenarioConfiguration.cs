using Cheetah.Domain.Entities.Links;

namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Process.Links;

public class L_ProcessScenarioConfiguration : IEntityTypeConfiguration<L_ProcessScenario>
{
    public void Configure(EntityTypeBuilder<L_ProcessScenario> builder)
    {
        builder.HasComment("Related scenarios of each flow");

        builder
            .HasOne(x => x.Process)
            .WithMany(x => x.ProcessScenarios)
            .HasForeignKey(x => x.FirstId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(x => x.Scenario)
            .WithMany(x => x.ProcessScenarios)
            .HasForeignKey(x => x.SecondId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
