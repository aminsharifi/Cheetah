namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Links;

public class L_FlowTaskConfiguration : IEntityTypeConfiguration<L_FlowTask>
{
    public void Configure(EntityTypeBuilder<L_FlowTask> builder)
    {
        builder
            .HasOne(x => x.Flow)
            .WithOne()
            .HasForeignKey<L_FlowTask>(x => x.FirstId);

        builder
            .HasOne(x => x.Task)
            .WithOne()
            .HasForeignKey<L_FlowTask>(x => x.SecondId);
    }
}
