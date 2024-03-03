namespace Cheetah.Infrastructure.Persistence.Data.Configurations;

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

                if (entityType.ClrType.BaseType.Name == nameof(BaseEntity)
                    ||
                    entityType.ClrType.BaseType?.BaseType?.Name == nameof(BaseEntity)
                    )
                {
                    entity.HasKey(nameof(BaseEntity.Id));

                    entity.Property(nameof(BaseEntity.Id))
                        .HasColumnOrder(1).UseIdentityColumn();


                    entity.Property(nameof(BaseEntity.SortIndex))
                        .HasColumnOrder(2)
                        .HasDefaultValue((long)0)
                        .ValueGeneratedOnAdd();

                    entity.HasIndex(nameof(BaseEntity.Name))
                        .IsDescending();

                    entity.Property(nameof(BaseEntity.Name))
                        .HasColumnOrder(3)
                        .HasDefaultValue(string.Empty)
                        .HasMaxLength(512);

                    entity.Property(nameof(BaseEntity.DisplayName))
                        .HasColumnOrder(4)
                        .HasDefaultValue(string.Empty)
                        .HasMaxLength(512);

                    entity.Property(nameof(BaseEntity.Description))
                        .HasColumnOrder(5)
                        .HasDefaultValue(string.Empty)
                        .HasMaxLength(512);

                    entity.HasIndex(nameof(BaseEntity.Created)).IsDescending();

                    entity.Property(nameof(BaseEntity.Created))
                        .HasColumnOrder(6)
                        .HasDefaultValue(DateTimeOffset.Now)
                        .ValueGeneratedOnAdd();

                    entity.Property(nameof(BaseEntity.LastModified))
                        .HasColumnOrder(7)
                        .IsConcurrencyToken(true);

                    entity.HasIndex(nameof(BaseEntity.LastModified))
                        .IsDescending();

                    entity.Property(nameof(BaseEntity.GuidRecord))
                        .HasColumnOrder(8)
                        .HasDefaultValue(Guid.NewGuid());

                    entity.HasIndex(nameof(BaseEntity.EnableRecord))
                        .IsDescending();

                    entity.Property(nameof(BaseEntity.EnableRecord))
                        .HasColumnOrder(9)
                        .HasDefaultValue(true);

                    entity.HasIndex(nameof(BaseEntity.ERPCode))
                        .IsDescending();

                    entity.Property(nameof(BaseEntity.ERPCode))
                        .HasColumnOrder(10);

                    entity
                        .Ignore(nameof(BaseEntity.DomainEvents));

                }
                if (entityType.ClrType.BaseType.Name == nameof(SimpleLinkClass))
                {
                    entity
                        .HasIndex(nameof(SimpleLinkClass.FirstId))
                        .IsDescending()
                        .IsUnique(false);
                    entity.Property(nameof(SimpleLinkClass.FirstId)).HasColumnOrder(100);

                    entity.HasIndex(nameof(SimpleLinkClass.SecondId))
                        .IsDescending()
                        .IsUnique(false);

                    entity.Property(nameof(SimpleLinkClass.SecondId)).HasColumnOrder(101);

                    entity.HasIndex(nameof(SimpleLinkClass.ThirdId))
                        .IsDescending()
                        .IsUnique(false);

                    entity.Property(nameof(SimpleLinkClass.ThirdId)).HasColumnOrder(102);

                    entity.HasIndex(nameof(SimpleLinkClass.FourthId))
                        .IsDescending()
                        .IsUnique(false);

                    entity.Property(nameof(SimpleLinkClass.FourthId))
                        .HasColumnOrder(103);

                    entity.HasIndex(nameof(SimpleLinkClass.FifthId))
                        .IsDescending()
                        .IsUnique(false);

                    entity.Property(nameof(SimpleLinkClass.FifthId)).HasColumnOrder(104);
                }
                else if (entityType.ClrType.BaseType?.BaseType?.Name == nameof(BaseEntity))
                {
                    entity
                        .HasOne(nameof(D_User.Parent))
                        .WithMany(nameof(D_User.Childs))
                        .HasForeignKey(nameof(D_User.Parent_Id));
                }
            }
        }
    }
}