namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Links;

public class L_FlowConditionConfiguration : IEntityTypeConfiguration<L_FlowCondition>
{
    public void Configure(EntityTypeBuilder<L_FlowCondition> builder)
    {
        builder.HasComment("Conditionals of each flow");

        builder
            .HasOne(x => x.Flow)
            .WithMany(x => x.FlowConditions)
            .HasForeignKey(x => x.FirstId);

        builder
            .HasIndex(x => x.SecondId);
    }
}
