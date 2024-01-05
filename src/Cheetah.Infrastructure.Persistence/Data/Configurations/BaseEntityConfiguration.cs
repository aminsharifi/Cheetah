﻿namespace Cheetah.Infrastructure.Persistence.Data.Configurations;

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

                if (entityType.ClrType.BaseType.Name == nameof(BaseEntity))
                {
                    entity.HasKey(nameof(BaseEntity.Id));
                    entity.HasIndex(nameof(BaseEntity.Name)).IsDescending().IsUnique();
                    entity.HasIndex(nameof(BaseEntity.Created)).IsDescending();
                    entity.HasIndex(nameof(BaseEntity.LastModified)).IsDescending();

                    entity.HasIndex(nameof(BaseEntity.ERPCode)).IsDescending();
                    entity.HasIndex(nameof(BaseEntity.EnableRecord)).IsDescending();
                    entity.Property(nameof(BaseEntity.Id)).HasColumnOrder(1).HasDefaultValue((long)0);
                    entity.Property(nameof(BaseEntity.SortIndex)).HasColumnOrder(2).HasDefaultValue((long)0);
                    entity.Property(nameof(BaseEntity.Name)).HasColumnOrder(3).HasDefaultValue(string.Empty).HasMaxLength(512);
                    entity.Property(nameof(BaseEntity.DisplayName)).HasColumnOrder(4).HasDefaultValue(string.Empty).HasMaxLength(512);
                    entity.Property(nameof(BaseEntity.Description)).HasColumnOrder(5).HasDefaultValue(string.Empty).HasMaxLength(512);
                    entity.Property(nameof(BaseEntity.Created)).HasColumnOrder(6).HasDefaultValue(DateTimeOffset.Now).ValueGeneratedOnAdd();
                    entity.Property(nameof(BaseEntity.LastModified)).HasColumnOrder(7).HasDefaultValue(DateTimeOffset.Now)
                        .ValueGeneratedOnAddOrUpdate().IsConcurrencyToken(true);

                    entity.Property(nameof(BaseEntity.GuidRecord)).HasColumnOrder(8)
                        .HasDefaultValue(Guid.NewGuid());
                    entity.Property(nameof(BaseEntity.EnableRecord)).HasColumnOrder(9)
                        .HasDefaultValue(true);
                    entity.Property(nameof(BaseEntity.ERPCode)).HasColumnOrder(10);
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