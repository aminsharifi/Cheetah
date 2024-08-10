using Cheetah.Core.Entities.Facts;

namespace Cheetah.Infrastructure.Data.Configurations.Process.Facts;

public class F_TaskConfiguration : IEntityTypeConfiguration<F_Task>
{
    public void Configure(EntityTypeBuilder<F_Task> builder)
    {
        builder
            .HasComment("Entities like position, role, etc.");

        builder
            .Property(e => e.ScenarioId)
            .HasColumnOrder(101);

        builder
            .Property(e => e.FormId)
            .HasColumnOrder(102);


        //builder
        //    .HasMany(x => x.TaskConditions)
        //    .WithOne(x => x.Task)
        //    .HasForeignKey(x => x.FirstId);

    }
}
