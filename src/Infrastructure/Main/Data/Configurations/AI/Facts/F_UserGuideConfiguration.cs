using Cheetah.Core.Aggregates.AIAggregate.Facts;

namespace Cheetah.Infrastructure.Data.Configurations.AI.Facts;

public class F_UserGuideConfiguration : IEntityTypeConfiguration<F_UserGuide>
{
    public void Configure(EntityTypeBuilder<F_UserGuide> builder)
    {
        builder
            .HasComment("UserGuides for FAQ");

        builder.Property(e => e.Subject)
            .HasMaxLength(1024);

        builder.Property(e => e.Description)
            .HasMaxLength(1024);

        builder.Property(e => e.Keywords)
            .HasMaxLength(1024);

        builder.Property(e => e.Body)
              .HasColumnType("nvarchar(max)"); // Set the property to nvarchar(max)

    }
}
