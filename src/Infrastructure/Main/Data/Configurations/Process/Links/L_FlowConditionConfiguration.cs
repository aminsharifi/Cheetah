using Cheetah.Core.Aggregates.ConditionAggregate.Facts;
using Cheetah.Core.Aggregates.ProcessAggregate.Links;

namespace Cheetah.Infrastructure.Data.Configurations.Process.Links;

public class L_FlowConditionConfiguration : IEntityTypeConfiguration<L_FlowCondition>
{
    public void Configure(EntityTypeBuilder<L_FlowCondition> builder)
    {
        builder.HasComment("Conditionals of each flow");

        builder
            .HasOne(x => x.Flow)
            .WithMany(x => x.FlowConditions)
            .HasForeignKey(x => x.FirstId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne<F_Condition>()  // Define the relationship with the Parent entity
            .WithMany()  // Specify that there can be multiple Child entities related to one Parent
            .HasForeignKey(c => c.SecondId)
            .OnDelete(DeleteBehavior.Restrict);  // Set the foreign key property in the Child entity
    }
}
