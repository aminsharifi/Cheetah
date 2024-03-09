namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Links;

public class L_TaskFlowConfiguration : IEntityTypeConfiguration<L_TaskFlow>
{
    public void Configure(EntityTypeBuilder<L_TaskFlow> builder)
    {
        builder.HasComment("Exit flows of each task");

        builder
            .HasOne(x => x.Task)
            .WithMany(x => x.TaskFlows)
            .HasForeignKey(x => x.FirstId);

        builder
            .HasOne(x => x.Flow)
            .WithMany(x => x.TaskFlows)
            .HasForeignKey(x => x.SecondId);
    }
}
