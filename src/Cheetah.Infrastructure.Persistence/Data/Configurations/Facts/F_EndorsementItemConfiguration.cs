namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Facts;

public class F_EndorsementItemConfiguration : IEntityTypeConfiguration<F_EndorsementItem>
{
    public void Configure(EntityTypeBuilder<F_EndorsementItem> builder)
    {
        builder
        .Property(e => e.CaseStateId)
        .HasColumnOrder(101);

        builder
         .Property(e => e.EndorsementId)
         .HasColumnOrder(102);
    }
}
