namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Links;

public class L_FlowTaskConfiguration : IEntityTypeConfiguration<L_FlowTask>
{
    public void Configure(EntityTypeBuilder<L_FlowTask> builder)
    {
        builder
            .HasOne(x => x.Flow)
            .WithMany(x => x.FlowTasks)
            .HasForeignKey(x => x.FirstId);

        builder
            .HasOne(x => x.Task)
            .WithMany(x => x.FlowTasks)
            .HasForeignKey(x => x.SecondId);
    }
}
