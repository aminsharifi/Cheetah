namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Links;

public class L_UserConditionGroupConfiguration : IEntityTypeConfiguration<L_UserConditionGroup>
{
    public void Configure(EntityTypeBuilder<L_UserConditionGroup> builder)
    {
        builder
            .HasOne(x => x.User)
            .WithOne()
            .HasForeignKey<L_UserConditionGroup>(x => x.FirstId);

        builder
            .HasOne(x => x.ConditionGroup)
            .WithOne()
            .HasForeignKey<L_UserConditionGroup>(x => x.SecondId);
    }
}
