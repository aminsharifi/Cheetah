namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Links;

public class L_ConditionGroupConditionConfiguration : IEntityTypeConfiguration<L_ConditionGroupCondition>
{
    public void Configure(EntityTypeBuilder<L_ConditionGroupCondition> builder)
    {
        builder
            .HasOne(x => x.ConditionGroup)
            .WithMany(x=>x.ConditionGroupConditions)
            .HasForeignKey(x => x.FirstId);

        builder
            .HasOne(x => x.Condition)
            .WithMany(x => x.ConditionGroupConditions)
            .HasForeignKey(x => x.SecondId);
    }
}