namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Links;

public class L_ScenarioConditionConfiguration : IEntityTypeConfiguration<L_ScenarioCondition>
{
    public void Configure(EntityTypeBuilder<L_ScenarioCondition> builder)
    {
        builder.HasComment("Conditionals of each scenario");

        builder
            .HasOne(x => x.Scenario)
            .WithMany(x => x.ScenarioConditions)
            .HasForeignKey(x => x.FirstId);

        builder
            .HasOne(x => x.Condition)
            .WithMany(x => x.ScenarioConditions)
            .HasForeignKey(x => x.SecondId);
    }
}
