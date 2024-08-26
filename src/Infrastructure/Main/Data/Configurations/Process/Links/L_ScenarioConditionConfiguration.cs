using Cheetah.Core.Aggregates.ConditionAggregate.Facts;
using Cheetah.Core.Aggregates.ProcessAggregate.Links;

namespace Cheetah.Infrastructure.Data.Configurations.Process.Links;

public class L_ScenarioConditionConfiguration : IEntityTypeConfiguration<L_ScenarioCondition>
{
    public void Configure(EntityTypeBuilder<L_ScenarioCondition> builder)
    {
        builder.HasComment("Conditionals of each scenario");

        builder
            .HasOne(x => x.Scenario)
            .WithMany(x => x.ScenarioConditions)
            .HasForeignKey(x => x.FirstId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne<F_Condition>()
            .WithMany()
            .HasForeignKey(x => x.SecondId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
