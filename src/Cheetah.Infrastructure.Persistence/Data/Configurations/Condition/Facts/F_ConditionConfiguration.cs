namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Condition.Facts;

public class F_ConditionConfiguration : IEntityTypeConfiguration<F_Condition>
{
    public void Configure(EntityTypeBuilder<F_Condition> builder)
    {
        builder.HasComment("Condition of each tag");

        builder
            .Property(e => e.TagId)
            .HasColumnOrder(100);

        builder
            .Property(e => e.OperandId)
            .HasColumnOrder(101);

        builder
            .Property(e => e.Value)
            .HasColumnOrder(102);

        builder.Ignore(x => x.BooleanValue);

        builder.Ignore(x => x.FloatValue);
    }
}
