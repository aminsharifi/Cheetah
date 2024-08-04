using Cheetah.Core.Aggregates.ProcessAggregate.Links;

namespace Cheetah.Infrastructure.Data.Configurations.Process.Links;

public class L_FlowTaskConfiguration : IEntityTypeConfiguration<L_FlowTask>
{
    public void Configure(EntityTypeBuilder<L_FlowTask> builder)
    {
        builder.HasComment("Exit tasks of each flow");

        builder
            .HasOne(x => x.Flow)
            .WithMany(x => x.FlowTasks)
            .HasForeignKey(x => x.FirstId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(x => x.Task)
            .WithMany(x => x.FlowTasks)
            .HasForeignKey(x => x.SecondId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
