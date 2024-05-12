using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Cheetah.Infrastructure.Persistence.Data.Configurations;

public static class BaseEntityConfiguration
{
    public static void ConfigureSimpleClass(this ModelBuilder modelBuilder, DatabaseFacade database)
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

                    entity
                        .Property(nameof(BaseEntity.Id))
                        .HasColumnOrder(1)
                        .UseIdentityColumn()
                        .HasComment("The unique key of each record");


                    entity.Property(nameof(BaseEntity.SortIndex))
                        .HasColumnOrder(2)
                        .HasDefaultValue((long)0)
                        .ValueGeneratedOnAdd()
                        .HasComment("The sort index of the record");

                    entity.HasIndex(nameof(BaseEntity.Name))
                        .IsDescending();

                    entity.Property(nameof(BaseEntity.Name))
                        .HasColumnOrder(3)
                        .HasDefaultValue(string.Empty)
                        .HasMaxLength(512)
                        .HasComment("English name of each record");

                    entity.Property(nameof(BaseEntity.DisplayName))
                        .HasColumnOrder(4)
                        .HasDefaultValue(string.Empty)
                        .HasMaxLength(512)
                        .HasComment("The localized name of each record");

                    entity.Property(nameof(BaseEntity.Description))
                        .HasColumnOrder(5)
                        .HasDefaultValue(string.Empty)
                        .HasMaxLength(512)
                        .HasComment("Additional description of each record");

                    entity.HasIndex(nameof(BaseEntity.Created)).IsDescending();

                    entity.Property(nameof(BaseEntity.Created))
                        .HasColumnOrder(6)
                        .HasDefaultValueSql((database.IsSqlServer()) ? "GETDATE()" : "GETDATE()")
                        .ValueGeneratedOnAdd()
                        .HasComment("Record creation date");


                    entity.Property(nameof(BaseEntity.LastModified))
                        .HasColumnOrder(7)
                        //.IsConcurrencyToken(true)
                        //.IsRowVersion()
                        .HasDefaultValueSql((database.IsSqlServer()) ? "GETDATE()" : "GETDATE()")
                        .ValueGeneratedOnUpdate()
                        .HasComment("The date the record was last updated");

                    entity.HasIndex(nameof(BaseEntity.LastModified))
                        .IsDescending();

                    entity.Property(nameof(BaseEntity.GuidRecord))
                        .HasColumnOrder(8)
                        .HasDefaultValueSql((database.IsSqlServer()) ? "NEWSEQUENTIALID ()" : "newsequentialid()")
                        .HasComment("Unique GUID identifier");


                    entity.HasIndex(nameof(BaseEntity.EnableRecord))
                        .IsDescending();

                    entity.Property(nameof(BaseEntity.EnableRecord))
                        .HasColumnOrder(9)
                        .HasDefaultValue(true)
                        .HasComment("Active status of the record");

                    entity.HasIndex(nameof(BaseEntity.ERPCode))
                        .IsDescending();

                    entity.Property(nameof(BaseEntity.ERPCode))
                        .HasColumnOrder(10)
                        .HasComment("ID of this record in ERP");

                    entity.Property(nameof(BaseEntity.LastModifiedBy))
                        .HasColumnOrder(11)
                        .HasDefaultValue(string.Empty)
                        .HasMaxLength(512)
                        .HasComment("By which user has it been updated?");

                    entity.Property(nameof(BaseEntity.CreatedBy))
                        .HasColumnOrder(12)
                        .HasDefaultValue(string.Empty)
                        .HasMaxLength(512)
                        .HasComment("Created by what user?");


                    entity.Ignore(nameof(BaseEntity.DomainEvents));

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