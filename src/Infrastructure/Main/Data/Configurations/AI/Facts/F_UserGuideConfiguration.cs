using Cheetah.Core.Aggregates.AIAggregate.Facts;
using Cheetah.Core.Aggregates.UserAggregate.Dimentions;

namespace Cheetah.Infrastructure.Data.Configurations.AI.Facts;

public class F_UserGuideConfiguration : IEntityTypeConfiguration<F_UserGuide>
{
    public void Configure(EntityTypeBuilder<F_UserGuide> builder)
    {
        builder
            .HasComment("UserGuides for FAQ");

        builder.Property(e => e.JsonData)
             .HasColumnType("nvarchar(max)"); // Set the property to nvarchar(max)

        builder.Property(e => e.Body)
              .HasColumnType("nvarchar(max)"); // Set the property to nvarchar(max)

        builder.Property(e => e.VectorBody)
               .HasColumnType("VARBINARY(MAX)"); // Store as VARBINARY
    }
}
