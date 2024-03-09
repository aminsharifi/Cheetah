namespace Cheetah.Infrastructure.Persistence.Data.Configurations.Links;

public class L_CaseTaskUserConfiguration : IEntityTypeConfiguration<L_CaseTaskUser>
{
    public void Configure(EntityTypeBuilder<L_CaseTaskUser> builder)
    {
        builder.HasComment("Manual choosing performer");

        builder
            .HasOne(x => x.Case)
            .WithMany(x => x.CaseTaskUsers)
            .HasForeignKey(x => x.FirstId);

        builder
            .HasOne(x => x.Task)
            .WithMany(x => x.CaseTaskUsers)
            .HasForeignKey(x => x.SecondId);

        builder
            .HasOne(x => x.User)
            .WithMany(x => x.CaseTaskUsers)
            .HasForeignKey(x => x.ThirdId);
    }
}
