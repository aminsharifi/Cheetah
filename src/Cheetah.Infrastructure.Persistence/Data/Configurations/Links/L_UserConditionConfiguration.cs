namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Links;

public class L_UserConditionConfiguration : IEntityTypeConfiguration<L_UserCondition>
{
    public void Configure(EntityTypeBuilder<L_UserCondition> builder)
    {
        builder
            .HasOne(x => x.User)
            .WithMany(x=>x.UserConditions)
            .HasForeignKey(x => x.FirstId);

        builder
            .HasOne(x => x.Condition)
            .WithMany(x=>x.UserConditions)
            .HasForeignKey(x => x.SecondId);
    }
}
