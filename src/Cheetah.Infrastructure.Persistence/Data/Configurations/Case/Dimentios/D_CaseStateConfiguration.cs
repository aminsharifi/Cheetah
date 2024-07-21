using Cheetah.Domain.Entities.Dimentions;

namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Case.Dimentios;

public class D_CaseStateConfiguration : IEntityTypeConfiguration<D_CaseState>
{
    public void Configure(EntityTypeBuilder<D_CaseState> builder)
    {
        builder.HasComment("State of the case");
    }
}
