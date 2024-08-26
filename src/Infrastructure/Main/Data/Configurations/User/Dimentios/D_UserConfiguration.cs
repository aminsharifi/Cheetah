using Cheetah.Core.Aggregates.UserAggregate.Dimentions;

namespace Cheetah.Infrastructure.Data.Configurations.User.Dimentios;

public class D_UserConfiguration : IEntityTypeConfiguration<D_User>
{
    public void Configure(EntityTypeBuilder<D_User> builder)
    {
        builder.HasComment("Cheetah's user");

        #region Simple Prob

        builder
            .Property(e => e.Core)
            .HasColumnOrder(102)
            .HasMaxLength(25);

        builder
            .Property(e => e.EnabledForAssignation)
            .HasColumnOrder(103)
            .HasDefaultValue(true);

        builder
            .Property(e => e.DelegateEnabled)
            .HasColumnOrder(104)
            .HasDefaultValue(false);

        builder
            .Property(e => e.CreatedCasesSkipAssigRules)
            .HasColumnOrder(105)
            .HasDefaultValue(false);

        builder
            .Property(e => e.IDPersonel)
            .HasColumnOrder(106)
            .HasMaxLength(10);

        builder
            .Property(e => e.LDAPDescription)
            .HasColumnOrder(107)
            .HasMaxLength(20);

        #endregion

        #region Entity   

        #region S_User

        builder
            .Property(e => e.DelegateId)
            .HasColumnOrder(109);

        builder
            .Property(e => e.UserInformationId)
            .HasColumnOrder(110);

        builder
            .HasOne(e => e.Delegate)
            .WithOne()
            .HasForeignKey<D_User>(x => x.DelegateId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #endregion
    }
}
