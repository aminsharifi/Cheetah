namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Case.Facts;

public class F_WorkItemConfiguration : IEntityTypeConfiguration<F_WorkItem>
{
    public void Configure(EntityTypeBuilder<F_WorkItem> builder)
    {
        builder.HasComment("Numeric, Text, Date, binary");

        builder
            .Property(e => e.TaskId)
            .HasColumnOrder(101);

        builder
            .Property(e => e.UserId)
            .HasColumnOrder(102);

        builder
            .Property(e => e.CaseId)
            .HasColumnOrder(103);


        builder
            .Property(e => e.WorkItemStateId)
            .HasColumnOrder(105);
    }
}
