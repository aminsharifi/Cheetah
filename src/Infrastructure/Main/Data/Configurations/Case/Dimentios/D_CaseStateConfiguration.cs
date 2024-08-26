using Cheetah.Core.Aggregates.CaseAggregate.Dimentions;

namespace Cheetah.Infrastructure.Data.Configurations.Case.Dimentios;

public class D_CaseStateConfiguration : IEntityTypeConfiguration<D_CaseState>
{
    public void Configure(EntityTypeBuilder<D_CaseState> builder)
    {
        builder.HasComment("State of the case");
    }
}
