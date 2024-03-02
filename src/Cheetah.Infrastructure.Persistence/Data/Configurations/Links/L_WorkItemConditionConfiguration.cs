namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Links;

public class L_WorkItemConditionConfiguration : IEntityTypeConfiguration<L_WorkItemCondition>
{
    public void Configure(EntityTypeBuilder<L_WorkItemCondition> builder)
    {
        builder
            .HasOne(x => x.WorkItem)
            .WithOne()
            .HasForeignKey<L_WorkItemCondition>(x => x.FirstId);

        builder
            .HasOne(x => x.Condition)
            .WithOne()
            .HasForeignKey<L_WorkItemCondition>(x => x.SecondId);
    }
}
