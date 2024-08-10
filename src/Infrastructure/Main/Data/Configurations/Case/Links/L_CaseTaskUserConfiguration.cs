using Cheetah.Core.Aggregates.CaseAggregate.Links;
using Cheetah.Core.Entities.Dimentions;
using Cheetah.Core.Entities.Facts;

namespace Cheetah.Infrastructure.Data.Configurations.Case.Links;

public class L_CaseTaskUserConfiguration : IEntityTypeConfiguration<L_CaseTaskUser>
{
    public void Configure(EntityTypeBuilder<L_CaseTaskUser> builder)
    {
        builder.HasComment("Manual choosing performer");

        builder
            .HasOne(x => x.Case)
            .WithMany(x => x.CaseTaskUsers)
            .HasForeignKey(x => x.FirstId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne<F_Task>()
            .WithMany()
            .HasForeignKey(x => x.SecondId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne<D_User>()
            .WithMany()
            .HasForeignKey(x => x.ThirdId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
