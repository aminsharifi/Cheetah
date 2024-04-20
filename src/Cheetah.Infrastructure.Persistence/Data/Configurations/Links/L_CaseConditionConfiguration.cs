namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Links;

public class L_CaseConditionConfiguration : IEntityTypeConfiguration<L_CaseCondition>
{
    public void Configure(EntityTypeBuilder<L_CaseCondition> builder)
    {
        builder.HasComment("Conditions of each case for selecting correct scenario");

        builder
            .HasOne(x => x.Case)
            .WithMany(x=>x.CaseConditions)
            .HasForeignKey(x => x.FirstId);

        builder
            .HasIndex(x => x.SecondId);
    }
}
