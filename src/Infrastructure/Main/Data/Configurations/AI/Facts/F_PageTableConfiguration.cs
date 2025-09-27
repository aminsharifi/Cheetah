using Cheetah.Core.Aggregates.AIAggregate.Facts;

namespace Cheetah.Infrastructure.Data.Configurations.AI.Facts;

public class F_PageTableConfiguration : IEntityTypeConfiguration<F_PageTable>
{
    public void Configure(EntityTypeBuilder<F_PageTable> builder)
    {
        builder
            .HasComment("UserGuides for FAQ");

        builder.Property(e => e.JsonData)
             .HasColumnType("nvarchar(max)"); // Set the property to nvarchar(max)

        builder.Property(e => e.Policy)
              .HasMaxLength(1024);
    }
}
