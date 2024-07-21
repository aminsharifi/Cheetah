using Cheetah.Domain.Aggregates.ProcessAggregate.Links.TaskCondition;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Process.Links;

public class L_TaskConditionConfiguration : IEntityTypeConfiguration<L_TaskCondition>
{
    public void Configure(EntityTypeBuilder<L_TaskCondition> builder)
    {
        builder.HasComment("Conditionals of each task");

        builder
            .HasOne(x => x.Task)
            .WithMany(x => x.TaskConditions)
            .HasForeignKey(x => x.FirstId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne<F_Condition>()
            .WithMany()
            .HasForeignKey(x => x.SecondId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .Metadata
            .SetSchema("Links");

    }
}
