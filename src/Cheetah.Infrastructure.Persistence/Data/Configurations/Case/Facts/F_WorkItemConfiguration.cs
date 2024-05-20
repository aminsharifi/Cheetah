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
            .HasOne<F_Task>()
            .WithMany()
            .HasForeignKey(x => x.TaskId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .Property(e => e.UserId)
            .HasColumnOrder(102);

        builder
            .HasOne<D_User>()
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .Property(e => e.CaseId)
            .HasColumnOrder(103);

        builder
            .HasOne(x=>x.Case)
            .WithMany()
            .HasForeignKey(x => x.CaseId)
            .OnDelete(DeleteBehavior.Restrict);


        builder
            .Property(e => e.WorkItemStateId)
            .HasColumnOrder(105);

        builder
            .HasOne(x=>x.WorkItemState)
            .WithMany()
            .HasForeignKey (x => x.WorkItemStateId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
