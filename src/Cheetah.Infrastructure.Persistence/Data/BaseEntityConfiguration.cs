namespace Cheetah.Infrastructure.Persistence;

public static class BaseEntityConfiguration
{
    static void Configure<TEntity>(ModelBuilder modelBuilder)
        where TEntity : SimpleClass
    {
        modelBuilder.Entity<TEntity>(builder =>
        {
            #region SimpleClass

            #region General
            builder
                .HasKey(x => x.Id);

            builder
                .HasIndex(x => x.Name)
                .IsDescending()
                .IsUnique();

            builder
                .HasIndex(x => x.CreateTimeRecord)
                .IsDescending()
                .IsUnique();

            builder
                .HasIndex(x => x.LastUpdatedRecord)
                .IsDescending()
                .IsUnique();

            builder
                .HasIndex(x => x.ERPCode)
                .IsDescending();

            builder
                .HasIndex(x => x.EnableRecord)
                .IsDescending();

            builder.ToTable(nameof(TEntity), nameof(TableType.Dimentions));

            #endregion

            #region Id
            builder
                  .Property(s => s.Id)
                  .HasColumnOrder(1)
                  .HasDefaultValue((long)0);
            #endregion

            #region SortIndex
            builder
                  .Property(s => s.SortIndex)
                  .HasColumnOrder(2)
                  .HasDefaultValue((long)0);
            #endregion

            #region Name
            builder
                 .Property(s => s.Name)
                 .HasColumnOrder(3)
                 .HasDefaultValue(String.Empty)
                 .HasMaxLength(512);
            #endregion

            #region DisplayName       
            builder
                .Property(s => s.DisplayName)
                .HasColumnOrder(4)
                .HasDefaultValue(String.Empty)
                .HasMaxLength(512);
            #endregion

            #region Description
            builder
                  .Property(s => s.Description)
                  .HasColumnOrder(5)
                  .HasDefaultValue(String.Empty)
                  .HasMaxLength(512);
            #endregion

            #region CreateTimeRecord
            builder
                  .Property(s => s.CreateTimeRecord)
                  .HasColumnOrder(6)
                  .HasDefaultValue(DateTime.Now)
                  .ValueGeneratedOnAdd();
            #endregion

            #region LastUpdatedRecord
            builder
                  .Property(s => s.LastUpdatedRecord)
                  .HasColumnOrder(7)
                  .HasDefaultValue(DateTime.Now)
                  .ValueGeneratedOnAddOrUpdate()
                  .IsConcurrencyToken(true);
            #endregion

            #region GuidRecord
            builder
                  .Property(s => s.GuidRecord)
                  .HasColumnOrder(8)
                  .HasDefaultValue(Guid.NewGuid());
            #endregion

            #region EnableRecord
            builder
                  .Property(s => s.EnableRecord)
                  .HasColumnOrder(9)
                  .HasDefaultValue(true);
            #endregion

            #region ERPCode
            builder
                  .Property(s => s.ERPCode)
                  .HasColumnOrder(10);
            #endregion

            #endregion

        });
    }

    static void ConfigureLink<TEntity>(ModelBuilder modelBuilder)
       where TEntity : SimpleLinkClass
    {
        Configure<TEntity>(modelBuilder);

        modelBuilder.Entity<TEntity>(builder =>
        {
            builder
              .HasIndex(x => x.FirstId)
              .IsDescending()
              .IsUnique();

            builder
              .HasIndex(x => x.SecondId)
              .IsDescending()
              .IsUnique();

            builder
               .Property(s => s.FirstId)
               .HasColumnOrder(100);

            builder
               .Property(s => s.SecondId)
               .HasColumnOrder(101);
        }
        );
    }

    public static ModelBuilder ApplyBaseEntityConfiguration(this ModelBuilder modelBuilder)
    {
        var method = typeof(BaseEntityConfiguration).GetTypeInfo().DeclaredMethods
            .Single(m => m.Name == nameof(Configure));

        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            if (entityType.ClrType.IsBaseEntity(out var T))
                method.MakeGenericMethod(entityType.ClrType, T).Invoke(null, new[] { modelBuilder });
        }
        return modelBuilder;
    }

    static bool IsBaseEntity(this Type type, out Type T)
    {
        for (var baseType = type.BaseType; baseType != null; baseType = baseType.BaseType)
        {
            if (baseType.IsGenericType && baseType.GetGenericTypeDefinition() == typeof(SimpleClass))
            {
                T = baseType.GetGenericArguments()[0];
                return true;
            }
        }
        T = null;
        return false;
    }
}