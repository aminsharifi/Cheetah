using Microsoft.EntityFrameworkCore;

namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Facts;

public class F_ConditionConfiguration : IEntityTypeConfiguration<F_Condition>
{
    public void Configure(EntityTypeBuilder<F_Condition> builder)
    {
        builder
            .Property(e => e.TagId)
            .HasColumnOrder(100);

        builder
            .Property(e => e.OperandId)
            .HasColumnOrder(101);

        builder
            .Property(e => e.Value)
            .HasColumnOrder(102);

        builder.Ignore(x=>x.BooleanValue);

        builder.Ignore(x => x.FloatValue);        
    }
}
