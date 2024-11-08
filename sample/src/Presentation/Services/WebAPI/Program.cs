using Cheetah.Sample.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

if (builder.Environment.IsProduction())
{
    //builder.WebHost.ConfigureKestrel(serverOptions =>
    //{
    //    serverOptions.ListenAnyIP(1991, cfg => { cfg.Protocols = HttpProtocols.Http1; });
    //});
}

builder.Services.AddFastEndpoints()
                .SwaggerDocument(o =>
                {
                    o.ShortSchemaNames = true;
                });

var app = await builder.InitializeSettingsAsync();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseShowAllServicesMiddleware(); // see https://github.com/ardalis/AspNetCoreStartupServices
}
else
{
    app.UseDefaultExceptionHandler(); // from FastEndpoints
    app.UseHsts();
}

app.UseFastEndpoints()
        .UseSwaggerGen(); // Includes AddFileServer and static files middleware

app.UseHttpsRedirection();

//app.UseAuthorization();

//app.UseAuthentication();

app.MapGet("/", () => Results.Ok("Ok!"));

app.Run();