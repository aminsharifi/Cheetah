using Cheetah.Domain.Entities.Dimentions;

namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Case.Dimentios;

public class D_WorkItemStateConfiguration : IEntityTypeConfiguration<D_WorkItemState>
{
    public void Configure(EntityTypeBuilder<D_WorkItemState> builder)
    {
        builder.HasComment("State of the WorkItem");
    }
}
