namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Facts;

public class F_TaskItemConfiguration : IEntityTypeConfiguration<F_TaskItem>
{
    public void Configure(EntityTypeBuilder<F_TaskItem> builder)
    {
        builder
        .Property(e => e.CaseStateId)
        .HasColumnOrder(101);

        builder
         .Property(e => e.ToTaskId)
         .HasColumnOrder(102);
    }
}
