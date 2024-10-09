using Cheetah.Core.Aggregates.ConditionAggregate.Facts;

namespace Cheetah.Infrastructure.Data.Configurations.Condition.Facts;

public class F_ConditionConfiguration : IEntityTypeConfiguration<F_Condition>
{
    public void Configure(EntityTypeBuilder<F_Condition> builder)
    {
        builder.HasComment("Condition of each tag");

        builder
            .Property(e => e.ColorId)
            .HasColumnOrder(100);

        builder
            .HasOne(x => x.Color)
            .WithMany()
            .HasForeignKey(x => x.ColorId)
            .OnDelete(DeleteBehavior.Restrict);


        builder
            .Property(e => e.TagId)
            .HasColumnOrder(100);

        builder
            .HasOne(x => x.Tag)
            .WithMany()
            .HasForeignKey(x => x.TagId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .Property(e => e.OperandId)
            .HasColumnOrder(101);

        builder
            .HasOne(x => x.Operand)
            .WithMany()
            .HasForeignKey(x => x.OperandId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .Property(e => e.Value)
            .HasColumnOrder(102);

        builder
            .Property(e => e.CheckValidation)
            .HasColumnOrder(103);

        builder.Ignore(x => x.BooleanValue);

        builder.Ignore(x => x.FloatValue);
    }
}
