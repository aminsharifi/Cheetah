using Cheetah.Core.Aggregates.CaseAggregate.Links;
using Cheetah.Core.Aggregates.ConditionAggregate.Facts;

namespace Cheetah.Infrastructure.Data.Configurations.Case.Links;

public class L_CaseConditionConfiguration : IEntityTypeConfiguration<L_CaseCondition>
{
    public void Configure(EntityTypeBuilder<L_CaseCondition> builder)
    {
        builder.HasComment("Conditions of each case for selecting correct scenario");

        builder
            .HasOne(x => x.Case)
            .WithMany(x => x.CaseConditions)
            .HasForeignKey(x => x.FirstId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne<F_Condition>()
            .WithMany()
            .HasForeignKey(x => x.SecondId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}