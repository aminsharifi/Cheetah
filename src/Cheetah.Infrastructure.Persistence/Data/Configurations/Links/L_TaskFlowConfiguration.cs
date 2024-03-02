namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Links;

public class L_TaskFlowConfiguration : IEntityTypeConfiguration<L_TaskFlow>
{
    public void Configure(EntityTypeBuilder<L_TaskFlow> builder)
    {
        builder
            .HasOne(x => x.Task)
            .WithOne()
            .HasForeignKey<L_TaskFlow>(x => x.FirstId);

        builder
            .HasOne(x => x.Flow)
            .WithOne()
            .HasForeignKey<L_TaskFlow>(x => x.SecondId);
    }
}
