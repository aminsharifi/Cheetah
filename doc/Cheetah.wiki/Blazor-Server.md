
# Cheetah Blazor Server!

**Cheetah** Use Blazor for the web App.
With Blazor, we can get full control over which part of our program runs on the server and which part runs on the client. There can also be shared code for both parts! Blazor enables code sharing by allowing the same class or model to be reused on the server side as well as the client side.
you can use this API for communication between Cheetah and your application.

## Installation
You can Install Cheetah gRPC via:
> `docker pull ghcr.io/aminsharifi/cheetah.blazor.server:latest`
or by the links provided below:
https://github.com/aminsharifi/Cheetah/pkgs/container/cheetah.blazor.server

## Invoke
You can invoke Cheetah gRPC via:
> `localhost:5000`


## Program.cs

    var builder = WebApplication.CreateBuilder(args);
    
    if (builder.Environment.IsProduction())
    {
        builder.WebHost.ConfigureKestrel(serverOptions =>
        {
            serverOptions.ListenAnyIP(1988, cfg => { cfg.Protocols = HttpProtocols.Http1; });
        });
    
        builder.Host.ConfigureAppConfiguration((_, config) => { config.Sources.Clear(); });
        builder.Configuration.AddConsul(Environment.GetEnvironmentVariable("Key_Consul") ?? string.Empty,
            options =>
            {
                options.ConsulConfigurationOptions =
                    cco =>
                    {
                        cco.Address =
                            new Uri(Environment.GetEnvironmentVariable("Address_Consul") ?? string.Empty);
                        cco.Token = Environment.GetEnvironmentVariable("Token_Consul");
                    };
                options.Optional = true;
                options.PollWaitTime = TimeSpan.FromSeconds(5);
                options.ReloadOnChange = true;
            });
    }
    
    #region Serilog
    builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));
    #endregion
    
    StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);
    
    builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    
    builder.Services.AddIdentity<IdentityUser, IdentityRole>()
        .AddDefaultTokenProviders().AddDefaultUI()
        .AddEntityFrameworkStores<ApplicationDbContext>();
    
    builder.Services.AddTransient<DbInitialiser>();
    builder.Services.AddSingleton<WeatherForecastService>();
    builder.Services.AddSingleton<IGlobalization>
        (x => new Globalization(nameof(Cheetah) + "." + nameof(Cheetah.Presentation) + "." +
        nameof(Cheetah.Presentation.Web) + "." +
        nameof(Cheetah.Presentation.Web.Blazor) + "." + nameof(Cheetah.Presentation.Web.Blazor.Server)));
    builder.Services.AddScoped<IDbInitializer, DbInitializer>();
    builder.Services.AddScoped(typeof(ITableCRUD), typeof(TableCRUD));
    builder.Services.AddScoped(typeof(ITableCRUD), typeof(TableCRUD));
    builder.Services.AddScoped(typeof(IWorkItem), typeof(WorkItem));
    builder.Services.AddScoped(typeof(ISync), typeof(Sync));
    builder.Services.AddScoped(typeof(ICartable), typeof(Cartable));
    builder.Services.AddScoped(typeof(ICopyClass), typeof(CopyClass));
    builder.Services.AddScoped<CNavigation>();
    
    //var DomainName = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
    
    var provider = builder.Configuration.GetValue("Provider", "Npgsql");
    
    if (provider is "Npgsql")
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    
        builder.Services.AddDbContext<ApplicationDbContext>(
            b => b.UseLazyLoadingProxies()
            .UseNpgsql(builder.Configuration.GetConnectionString("Npgsql")
            , x => x.MigrationsAssembly(nameof(Cheetah) + "." +
            nameof(Cheetah.Infrastructure) + "." +
            nameof(Cheetah.Infrastructure.Persistence) + "." +
            nameof(Cheetah.Infrastructure.Persistence.Providers) + "." +
            nameof(Cheetah.Infrastructure.Persistence.Providers.Npgsql))
            ),
            ServiceLifetime.Transient
            );
    }
    else
    {
        builder.Services.AddDbContext<ApplicationDbContext>(
            b => b.UseLazyLoadingProxies()
            .UseSqlServer(builder.Configuration.GetConnectionString("SQLServer"),
            x => x.MigrationsAssembly(
                nameof(Cheetah) + "." +
            nameof(Cheetah.Infrastructure) + "." +
            nameof(Cheetah.Infrastructure.Persistence) + "." +
            nameof(Cheetah.Infrastructure.Persistence.Providers) + "." +
            nameof(Cheetah.Infrastructure.Persistence.Providers.SqlServer)
            )),
            ServiceLifetime.Transient
            );
    }
    
    // Add services to the container.
    builder.Services.AddRazorPages();
    builder.Services.AddServerSideBlazor();
    builder.Services.AddMudServices();
    builder.Services.AddBootstrapBlazor();
    
    //builder.Services.AddDefaultIdentity<ApplicationUser>()
    //    .AddEntityFrameworkStores<ApplicationDbContext>();
    
    
    
    var app = builder.Build();
    
    using var scope = app.Services.CreateScope();
    
    var services = scope.ServiceProvider;
    
    var initialiser = services.GetRequiredService<DbInitialiser>();
    
    await initialiser.Run();
    
    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }
    
    app.UseSerilogRequestLogging();
    
    app.UseHttpsRedirection();
    
    app.UseStaticFiles();
    
    app.UseRouting();
    
    await SeedDatabase();
    
    app.UseAuthentication();
    
    app.UseAuthorization();
    
    app.MapBlazorHub();
    
    app.MapFallbackToPage("/_Host");
    
    app.Run();
    
    async Task SeedDatabase()
    {
        using (var scope = app.Services.CreateScope())
        {
            var dbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
            await dbInitializer.Initialize();
        }
    }
