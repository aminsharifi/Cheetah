using Cheetah.Core.Entities.Facts;

namespace Cheetah.Infrastructure.Data.Configurations.Process.Facts;

public class F_FormConfiguration : IEntityTypeConfiguration<F_Form>
{
    public void Configure(EntityTypeBuilder<F_Form> builder)
    {
        builder.HasComment("Entitiy for forms");
    }
}
