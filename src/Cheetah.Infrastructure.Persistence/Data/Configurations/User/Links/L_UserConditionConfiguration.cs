namespace Cheetah.Infrastructure.Persistence.Data.Configurations.User.Links;

public class L_UserConditionConfiguration : IEntityTypeConfiguration<L_UserCondition>
{
    public void Configure(EntityTypeBuilder<L_UserCondition> builder)
    {
        builder.HasComment("Conditionals of each user");

        builder
            .HasOne(x => x.User)
            .WithMany(x => x.UserConditions)
            .HasForeignKey(x => x.FirstId);

        builder
            .HasIndex(x => x.SecondId);
    }
}
