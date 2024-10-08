﻿using Cheetah.Core.Aggregates.ConditionAggregate.Dimentions;
using Cheetah.Core.Interfaces;
using Cheetah.Core.Interfaces.Cartable;
using Cheetah.Core.Interfaces.WorkItem;
using Cheetah.Infrastructure.Services;
using Cheetah.UseCases.Services;
using Cheetah.UseCases.Validations;

namespace Cheetah.Infrastructure.Data;

public static class CheetahInitialiserExtensions
{
    public static WebApplicationBuilder CheetahConfigurationAsync(this WebApplicationBuilder builder, String connection)
    {
        builder.Services.AddValidatorsFromAssemblyContaining(typeof(BaseEntityValidation));

        #region MediatR
        var mediatRAssemblies = new[]
        {
            Assembly.GetAssembly(typeof(D_Tag)), // Core
            Assembly.GetAssembly(typeof(Cartable)), // UseCases
        };
        builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(mediatRAssemblies!));
        builder.Services.AddScoped(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
        builder.Services.AddScoped<IDomainEventDispatcher, MediatRDomainEventDispatcher>();
        #endregion

        #region Repository
        builder.Services.AddMemoryCache();
        builder.Services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
        builder.Services.AddScoped(typeof(IReadRepository<>), typeof(EfRepository<>));
        #endregion

        #region Mapster
        var mapperConfig = new Mapper(GetConfiguredMappingConfig());
        builder.Services.AddSingleton<IMapper>(mapperConfig);
        #endregion

        #region Cheetah Services
        builder.Services.AddScoped(typeof(ICheetahDbInitialiser), typeof(CheetahDbInitialiser));
        builder.Services.AddScoped(typeof(ISync), typeof(Sync));
        builder.Services.AddScoped(typeof(ITableCRUD), typeof(TableCRUD));
        builder.Services.AddScoped(typeof(IWorkItem), typeof(WorkItem));
        builder.Services.AddScoped(typeof(ICartable), typeof(Cartable));
        builder.Services.AddScoped(typeof(ICopyClass), typeof(CopyClass));
        #endregion

        #region DB
        var provider = builder.Configuration.GetValue("Provider", "Npgsql");

        var _nameSpace = "Cheetah.Infrastructure.Providers.";
        if (provider is "Npgsql")
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            builder.Services.AddDbContext<CheetahDbContext>(
                b => b.UseLazyLoadingProxies(true)
                .UseNpgsql(connection,
                x => x.MigrationsAssembly(_nameSpace + "Npgsql")
                ),
                ServiceLifetime.Transient
                );
        }
        else
        {
            builder.Services.AddDbContext<CheetahDbContext>(
                b => b.UseLazyLoadingProxies(true)
                .UseSqlServer(connection,
                x => x.MigrationsAssembly(_nameSpace + "SqlServer")
                .EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: TimeSpan.FromSeconds(30),
                    errorNumbersToAdd: null)
                ), ServiceLifetime.Transient);
        }
        #endregion

        return builder;
    }

    /// <summary>
    /// Mapster(Mapper) global configuration settings
    /// To learn more about Mapster,
    /// see https://github.com/MapsterMapper/Mapster
    /// </summary>
    /// <returns></returns>
    public static TypeAdapterConfig GetConfiguredMappingConfig()
    {
        var config = TypeAdapterConfig.GlobalSettings;

        var cheetahAssemblies = new[]
       {
            Assembly.GetAssembly(typeof(D_Tag)), // Core
            Assembly.GetAssembly(typeof(Cartable)), // UseCases
        };

        IList<IRegister> registers = config.Scan(cheetahAssemblies);

        config.Apply(registers);

        return config;
    }
}