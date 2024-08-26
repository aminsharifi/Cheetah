using Cheetah.Core.Aggregates.ConditionAggregate.Dimentions;

namespace Cheetah.Infrastructure.Data.Configurations.Condition.Dimentios;

public class D_OperandConfiguration : IEntityTypeConfiguration<D_Operand>
{
    public void Configure(EntityTypeBuilder<D_Operand> builder)
    {
        builder.HasComment("Operand name, like equal, greater, etc.");
    }
}
