using Microsoft.EntityFrameworkCore.Metadata;

namespace Cheetah.Infrastructure.Persistence;

public static class BaseEntityConfiguration
{
    public static void ConfigureSimpleClass(this ModelBuilder modelBuilder)
    {
        var _entityTypes = modelBuilder.Model.GetEntityTypes();

        foreach (IMutableEntityType entityType in _entityTypes)
        {
            if (Enum.IsDefined(typeof(TableType), entityType.ClrType.Namespace.Split('.').Last()))
            {
                entityType.SetTableName(entityType.ClrType.Name);
                entityType.SetSchema(entityType.ClrType.Namespace.Split('.').Last());
                var entity = modelBuilder.Entity(entityType.ClrType);

                if (entityType.ClrType.BaseType.Name == nameof(SimpleClass))
                {
                    entity.HasKey(nameof(SimpleClass.Id));
                    entity.HasIndex(nameof(SimpleClass.Name)).IsDescending().IsUnique();
                    entity.HasIndex(nameof(SimpleClass.CreateTimeRecord)).IsDescending();
                    entity.HasIndex(nameof(SimpleClass.LastUpdatedRecord)).IsDescending();

                    entity.HasIndex(nameof(SimpleClass.ERPCode)).IsDescending();
                    entity.HasIndex(nameof(SimpleClass.EnableRecord)).IsDescending();
                    entity.Property(nameof(SimpleClass.Id)).HasColumnOrder(1).HasDefaultValue((long)0);
                    entity.Property(nameof(SimpleClass.SortIndex)).HasColumnOrder(2).HasDefaultValue((long)0);
                    entity.Property(nameof(SimpleClass.Name)).HasColumnOrder(3).HasDefaultValue(String.Empty).HasMaxLength(512);
                    entity.Property(nameof(SimpleClass.DisplayName)).HasColumnOrder(4).HasDefaultValue(String.Empty).HasMaxLength(512);
                    entity.Property(nameof(SimpleClass.Description)).HasColumnOrder(5).HasDefaultValue(String.Empty).HasMaxLength(512);
                    entity.Property(nameof(SimpleClass.CreateTimeRecord)).HasColumnOrder(6).HasDefaultValue(DateTimeOffset.Now).ValueGeneratedOnAdd();
                    entity.Property(nameof(SimpleClass.LastUpdatedRecord)).HasColumnOrder(7).HasDefaultValue(DateTimeOffset.Now)
                        .ValueGeneratedOnAddOrUpdate().IsConcurrencyToken(true);

                    entity.Property(nameof(SimpleClass.GuidRecord)).HasColumnOrder(8)
                        .HasDefaultValue(Guid.NewGuid());
                    entity.Property(nameof(SimpleClass.EnableRecord)).HasColumnOrder(9)
                        .HasDefaultValue(true);
                    entity.Property(nameof(SimpleClass.ERPCode)).HasColumnOrder(10);
                }

                if (entityType.ClrType.BaseType.Name == nameof(SimpleLinkClass))
                {
                    entity.HasIndex(nameof(SimpleLinkClass.FirstId)).IsDescending().IsUnique();
                    entity.HasIndex(nameof(SimpleLinkClass.SecondId)).IsDescending().IsUnique();
                    entity.Property(nameof(SimpleLinkClass.FirstId)).HasColumnOrder(100);
                    entity.Property(nameof(SimpleLinkClass.SecondId)).HasColumnOrder(101);
                }
            }
        }
    }
}