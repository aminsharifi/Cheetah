namespace Cheetah.Infrastructure.Persistence.Data.Configurations;

public class D_TagTypeConfiguration : IEntityTypeConfiguration<D_TagType>
{
    public void Configure(EntityTypeBuilder<D_TagType> builder)
    {
        builder.HasComment("Numeric, Text, Date, binary");
    }
}
