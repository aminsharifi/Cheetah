namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Links;

public class L_CaseTaskUserConfiguration : IEntityTypeConfiguration<L_CaseTaskUser>
{
    public void Configure(EntityTypeBuilder<L_CaseTaskUser> builder)
    {
        builder
            .HasOne(x => x.Case)
            .WithOne()
            .HasForeignKey<L_CaseTaskUser>(x => x.FirstId);

        builder
            .HasOne(x => x.Task)
            .WithOne()
            .HasForeignKey<L_CaseTaskUser>(x => x.SecondId);

        builder
            .HasOne(x => x.User)
            .WithOne()
            .HasForeignKey<L_CaseTaskUser>(x => x.ThirdId);
    }
}
