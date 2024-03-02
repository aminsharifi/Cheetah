namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Links;

public class L_WorkItemConditionConfiguration : IEntityTypeConfiguration<L_WorkItemCondition>
{
    public void Configure(EntityTypeBuilder<L_WorkItemCondition> builder)
    {
        builder
            .HasOne(x => x.WorkItem)
            .WithMany(x=>x.WorkItemConditions)
            .HasForeignKey(x => x.FirstId);

        builder
            .HasOne(x => x.Condition)
            .WithMany(x=>x.WorkItemConditions)
            .HasForeignKey(x => x.SecondId);
    }
}
