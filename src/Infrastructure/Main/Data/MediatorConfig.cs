using Cheetah.Core.Aggregates.ConditionAggregate.Dimentions;
using Cheetah.UseCases.Services;

namespace Cheetah.Infrastructure.Data;

public static class MediatorConfig
{
    // Should be called from ServiceConfigs.cs, not Program.cs
    public static IServiceCollection AddMediatorSourceGen(this IServiceCollection services)
    {
        //logger.LogInformation("Registering Mediator SourceGen and Behaviors");
        services.AddMediator(options =>
        {
            // Lifetime: Singleton is fastest per docs; Scoped/Transient also supported.
            options.ServiceLifetime = ServiceLifetime.Singleton;  // ← Change to Singleton

            // Supply any TYPE from each assembly you want scanned (the generator finds the assembly from the type)
            options.Assemblies =
            [
                typeof(D_Tag), // Core
                typeof(Cartable), // UseCases
                typeof(InfrastructureServiceExtensions), // Infrastructure
                typeof(MediatorConfig)                  // Web
            ];

            // Register pipeline behaviors here (order matters)
            options.PipelineBehaviors =
            [
              typeof(LoggingBehavior<,>)
            ];

            // If you have stream behaviors:
            // options.StreamPipelineBehaviors = [ typeof(YourStreamBehavior<,>) ];
        });

        // Alternative: register behaviors via DI yourself (useful if not doing AOT):
        // services.AddScoped(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
        // services.AddScoped(typeof(IPipelineBehavior<,>), typeof(CachingBehavior<,>));

        return services;
    }
}