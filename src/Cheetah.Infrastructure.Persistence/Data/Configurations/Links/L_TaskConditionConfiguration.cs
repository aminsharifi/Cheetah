namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Links;

public class L_TaskConditionConfiguration : IEntityTypeConfiguration<L_TaskCondition>
{
    public void Configure(EntityTypeBuilder<L_TaskCondition> builder)
    {
        builder
       .HasOne(x => x.Task)
       .WithOne()
       .HasForeignKey<L_TaskCondition>(x => x.FirstId);

        builder
            .HasOne(x => x.Condition)
            .WithOne()
            .HasForeignKey<L_TaskCondition>(x => x.SecondId);
    }
}
