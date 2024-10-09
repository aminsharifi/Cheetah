using Cheetah.Core.Aggregates.Common.Dimentions;
namespace Cheetah.Infrastructure.Data.Configurations.Base;

public class D_ColorConfiguration : IEntityTypeConfiguration<D_Color>
{
    public void Configure(EntityTypeBuilder<D_Color> builder)
    {
        builder.HasComment("Color's name of objects");
    }
}