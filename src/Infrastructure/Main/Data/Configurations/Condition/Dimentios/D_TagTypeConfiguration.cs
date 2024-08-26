using Cheetah.Core.Aggregates.ConditionAggregate.Dimentions;

namespace Cheetah.Infrastructure.Data.Configurations.Condition.Dimentios;

public class D_TagTypeConfiguration : IEntityTypeConfiguration<D_TagType>
{
    public void Configure(EntityTypeBuilder<D_TagType> builder)
    {
        builder.HasComment("Numeric, Text, Date, binary");
    }
}
