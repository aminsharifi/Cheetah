namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Case.Links;

public class L_WorkItemConditionConfiguration : IEntityTypeConfiguration<L_WorkItemCondition>
{
    public void Configure(EntityTypeBuilder<L_WorkItemCondition> builder)
    {
        builder.HasComment("Conditionals of each workitem");

        builder
            .HasOne(x => x.WorkItem)
            .WithMany(x => x.WorkItemConditions)
            .HasForeignKey(x => x.FirstId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne<F_Condition>()
            .WithMany()
            .HasForeignKey(x => x.SecondId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
