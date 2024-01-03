namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Facts;

public class F_EndorsementConfiguration : IEntityTypeConfiguration<F_Endorsement>
{
    public void Configure(EntityTypeBuilder<F_Endorsement> builder)
    {
        builder
         .Property(e => e.RoleId)
         .HasColumnOrder(100);

        builder
         .Property(e => e.ScenarioId)
         .HasColumnOrder(101);

        builder
         .Property(e => e.EndorsementItemId)
         .HasColumnOrder(102);

        builder
         .Property(e => e.ConditionId)
         .HasColumnOrder(103);
    }
}
