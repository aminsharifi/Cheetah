namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Links;

public class L_FlowConditionConfiguration : IEntityTypeConfiguration<L_FlowCondition>
{
    public void Configure(EntityTypeBuilder<L_FlowCondition> builder)
    {
        builder
       .HasOne(x => x.Flow)
       .WithOne()
       .HasForeignKey<L_FlowCondition>(x => x.FirstId);

        builder
            .HasOne(x => x.Condition)
            .WithOne()
            .HasForeignKey<L_FlowCondition>(x => x.SecondId);
    }
}
