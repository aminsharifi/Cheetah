using Ardalis.SharedKernel;
using Cheetah.Domain.Interfaces;
using Cheetah.Infrastructure.Persistence.Data;
using Microsoft.Extensions.Caching.Memory;

namespace Cheetah.Infrastructure.Persistence;

public static class InfrastructureServiceExtensions
{
    public static IServiceCollection AddInfrastructureServices(
      this IServiceCollection services,
      ConfigurationManager config,
      Microsoft.Extensions.Logging.ILogger logger)
    {
        services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
        services.AddScoped(typeof(IReadRepository<>), typeof(EfRepository<>));

        //services.AddScoped<ICReadRepository<D_User>>(
        //    x => new CachedRepository<D_User>(
        //        x.GetRequiredService<IMemoryCache>(),
        //        x.GetRequiredService<Microsoft.Extensions.Logging.ILogger<CachedRepository<D_User>>>(),
        //        x.GetRequiredService<EfRepository<D_User>>()));


        return services;
    }
}
