using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Facts;

public class F_WorkItemConfiguration : IEntityTypeConfiguration<F_WorkItem>
{
    public void Configure(EntityTypeBuilder<F_WorkItem> builder)
    {
        builder
            .Property(e => e.EndorsementId)
            .HasColumnOrder(101);

        builder
            .Property(e => e.UserId)
            .HasColumnOrder(102);

        builder
            .Property(e => e.CaseId)
            .HasColumnOrder(103);

        builder
            .Property(e => e.TagId)
            .HasColumnOrder(104);

        builder
            .Property(e => e.WorkItemStateId)
            .HasColumnOrder(105);
    }
}
