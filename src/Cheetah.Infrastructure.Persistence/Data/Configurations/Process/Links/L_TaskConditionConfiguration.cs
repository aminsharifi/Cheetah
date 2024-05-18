namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Process.Links;

public class L_TaskConditionConfiguration : IEntityTypeConfiguration<L_TaskCondition>
{
    public void Configure(EntityTypeBuilder<L_TaskCondition> builder)
    {
        builder.HasComment("Conditionals of each task");

        builder
            .HasOne(x => x.Task)
            .WithMany(x => x.TaskConditions)
            .HasForeignKey(x => x.FirstId);

        builder
            .HasIndex(x => x.SecondId);

    }
}
