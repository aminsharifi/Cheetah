namespace Cheetah.Infrastructure.Persistence.Data.Configurations;

public class D_RoleConfiguration : IEntityTypeConfiguration<D_Role>
{
    public void Configure(EntityTypeBuilder<D_Role> builder)
    {
        builder
           .HasIndex(e => e.Independent)
           .IsUnique(false);

        builder
         .Property(e => e.Independent)
         .HasDefaultValue(false)
         .HasColumnOrder(100);

        builder
         .Property(e => e.FixedRole)
         .HasDefaultValue(false)
         .HasColumnOrder(101);
    }
}
