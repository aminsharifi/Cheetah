namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Links;

public class L_CaseConditionConfiguration : IEntityTypeConfiguration<L_CaseCondition>
{
    public void Configure(EntityTypeBuilder<L_CaseCondition> builder)
    {
        builder
            .HasOne(x => x.Case)
            .WithOne()
            .HasForeignKey<L_CaseCondition>(x => x.FirstId);

        builder
            .HasOne(x => x.Condition)
            .WithOne()
            .HasForeignKey<L_CaseCondition>(x => x.SecondId);
    }
}
