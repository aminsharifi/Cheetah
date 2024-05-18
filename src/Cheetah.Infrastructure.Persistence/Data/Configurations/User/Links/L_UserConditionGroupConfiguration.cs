namespace Cheetah.Infrastructure.Persistence.Data.Configurations.User.Links;

public class L_UserConditionGroupConfiguration : IEntityTypeConfiguration<L_UserConditionGroup>
{
    public void Configure(EntityTypeBuilder<L_UserConditionGroup> builder)
    {
        builder
            .HasOne(x => x.User)
            .WithMany(x => x.UserConditionGroups)
            .HasForeignKey(x => x.FirstId);

        builder
            .HasIndex(x => x.SecondId);
    }
}
