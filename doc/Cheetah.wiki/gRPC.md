# Cheetah gRPC!

**Cheetah** use gRPC with proto3 for API
you can use this API for communication between Cheetah and your application.

## Installation
You can Install Cheetah gRPC via:

> `docker pull ghcr.io/aminsharifi/cheetah.grpc:latest`

or by the links provided below:

https://github.com/aminsharifi/Cheetah/pkgs/container/cheetah.grpc


## ## Request.proto

```
syntax = "proto3";

import "google/protobuf/timestamp.proto";
import "google/protobuf/wrappers.proto";

option csharp_namespace = "Cheetah_GrpcService";

package greet;

// The greeting service definition.
service Request {
  // Sends a greeting
  rpc CreateRequest (CreateRequest_Input) returns (CreateRequest_Output);
  rpc GetCase (GetCase_Input) returns (GetCase_Output);
  rpc PerformRequest (PerformRequest_Input) returns (PerformRequest_Output);
  rpc Inbox (Cartable_Input) returns (Cartable_Output);
  rpc Outbox (Cartable_Input) returns (Cartable_Output);
  rpc GetAllByName (GetAllByName_Input) returns (GetAllByName_Output);
}

message CreateRequest_Input
{
     GRPC_BaseClass Case = 1;
     GRPC_BaseClassWithName Creator = 2;
     GRPC_BaseClassWithName Requestor = 3;
     GRPC_BaseClassWithName Process = 4;
     repeated Condition Conditions = 5;
}

message CreateRequest_Output
{
    GRPC_BaseClassWithDate Case = 1;
    GRPC_BaseClassWithName OutputState = 2;
}

message PerformRequest_Input
{
     GRPC_BaseClass WorkItem = 1;
     repeated Condition Conditions = 2;
}

message PerformRequest_Output
{
    GRPC_BaseClass Case = 1;
    GRPC_BaseClass Process = 2;
    GRPC_BaseClass CaseState = 3;
    GRPC_BaseClassWithName OutputState = 4;
}

message GetCase_Input
{
    GRPC_BaseClass Case = 1;
}

message Condition
{
    GRPC_BaseClassWithName Tag = 1;
    GRPC_BaseClassWithName Operand = 2;
    google.protobuf.StringValue Value = 3;
    GRPC_BaseClassWithName User = 4;
    GRPC_BaseClassWithName Base =5;
}

message GetCase_Output
{
    GRPC_BaseClass Case = 1;
    GRPC_BaseClassWithName CaseState = 2;
    GRPC_BaseClassWithName Process = 3;
    repeated GRPC_Endorsement Endorsements = 4;
    GRPC_BaseClassWithName OutputState = 5;
}

message GRPC_Endorsement
{
    GRPC_BaseClassWithName Endorsement = 1;
    repeated GRPC_WorkItem WorkItems = 2;
}

message GRPC_WorkItem
{
    GRPC_BaseClassWithDate WorkItem = 1;
    GRPC_BaseClassWithName User = 2;
    GRPC_BaseClassWithName Tag = 3;
    GRPC_BaseClassWithName WorkItemState = 4;
}

message Cartable_Input
{
    google.protobuf.Int64Value PageNumber = 1;
    google.protobuf.Int64Value PageSize  = 2;
    google.protobuf.Int64Value TotalItems  = 3;
    GRPC_BaseClassWithName Assignee = 4;
    GRPC_BaseClassWithName CaseState = 5;
    GRPC_BaseClassWithName Process = 6;
    GRPC_BaseClass Case  = 7;
    GRPC_BaseClass WorkItem  = 8;
}

message Cartable_Output
{
    google.protobuf.Int64Value PageNumber = 1;
    google.protobuf.Int64Value PageSize  = 2;
    google.protobuf.Int64Value TotalItems  = 3;    
    repeated RecordCartable RecordCartables = 4;
    GRPC_BaseClassWithName OutputState = 5;
}

message RecordCartable
{
    GRPC_BaseClassWithName Process = 1;
    GRPC_BaseClassWithDate Case  = 2;
    GRPC_BaseClassWithName CaseState = 3;
    GRPC_BaseClassWithName Requestor  = 4;
    GRPC_BaseClassWithName Endorsement = 5;
    GRPC_BaseClassWithDate WorkItem  = 6;
    GRPC_BaseClassWithName Assignee = 7;
    GRPC_BaseClassWithName Tag = 8;
    repeated GRPC_BaseClassWithName ValidUserActions = 9;
}

message GetAllByName_Input
{
    GRPC_BaseClassWithName TableInput = 1;
}

message GetAllByName_Output
{
    GRPC_BaseClassWithName TableInput = 1;
    repeated GRPC_BaseClassWithName TableOutput = 2;
    GRPC_BaseClassWithName OutputState = 3;
}

message GRPC_BaseClass
{
    google.protobuf.Int64Value Id = 1;
    google.protobuf.Int64Value ERPCode = 2;
    google.protobuf.Int64Value SortIndex = 3;
}

message GRPC_BaseClassWithName
{
    google.protobuf.Int64Value Id = 1;
    google.protobuf.Int64Value ERPCode = 2;
    google.protobuf.Int64Value SortIndex = 3;
    google.protobuf.StringValue Name = 4;
    google.protobuf.StringValue DisplayName = 5;
}

message GRPC_BaseClassWithDate
{
    google.protobuf.Int64Value Id = 1;
    google.protobuf.Int64Value ERPCode = 2;
    google.protobuf.Int64Value SortIndex = 3;
    google.protobuf.Timestamp CreateTimeRecord = 4;
    google.protobuf.Timestamp LastUpdatedRecord = 5;
}

message GRPC_BaseClassWithNameAndDate
{
    google.protobuf.Int64Value Id = 1;
    google.protobuf.Int64Value ERPCode = 2;
    google.protobuf.Int64Value SortIndex = 3;
    google.protobuf.StringValue Name = 4;
    google.protobuf.StringValue DisplayName = 5;
    google.protobuf.Timestamp CreateTimeRecord = 6;
    google.protobuf.Timestamp LastUpdatedRecord = 7;
}
```
## Program.cs
```
var builder = WebApplication.CreateBuilder(args);

if (builder.Environment.IsProduction())
{
    builder.WebHost.ConfigureKestrel(serverOptions =>
    {
        serverOptions.ListenAnyIP(1989, cfg => { cfg.Protocols = HttpProtocols.Http2; });
        serverOptions.ListenAnyIP(1990, cfg => { cfg.Protocols = HttpProtocols.Http1; });
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
builder.Host.UseSerilog((context, configuration) =>
    configuration.ReadFrom.Configuration(context.Configuration));
#endregion


var provider = builder.Configuration.GetValue("Provider", "Npgsql");

if (provider is "Npgsql")
{
    AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

    builder.Services.AddDbContext<ApplicationDbContext>(
        b => b.UseLazyLoadingProxies()
        .UseNpgsql(builder.Configuration.GetConnectionString("Npgsql")
        , x => x.MigrationsAssembly("Cheetah.Infrastructure.Persistence.Providers.Npgsql")
        ),
        ServiceLifetime.Transient
        );
}
else
{
    builder.Services.AddDbContext<ApplicationDbContext>(
        b => b.UseLazyLoadingProxies()
        .UseSqlServer(builder.Configuration.GetConnectionString("SQLServer"),
        x => x.MigrationsAssembly("Cheetah.Infrastructure.Persistence.Providers.SqlServer")),
        ServiceLifetime.Transient
        );
}

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped(typeof(ITableCRUD), typeof(TableCRUD));
builder.Services.AddScoped(typeof(IWorkItem), typeof(WorkItem));
builder.Services.AddScoped(typeof(ISync), typeof(Sync));
builder.Services.AddScoped(typeof(ICartable), typeof(Cartable));
builder.Services.AddScoped(typeof(ICopyClass), typeof(CopyClass));

//builder.Services.AddGrpc();

builder.Services.AddGrpc(options =>
{
    {
        options.Interceptors.Add<ServerLoggerInterceptor>();
        options.EnableDetailedErrors = true;
    }
});



builder.Services.AddTransient<ExceptionMiddleware>();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<GreeterService>();
app.MapGrpcService<RequestService>();
app.UseSerilogRequestLogging();
app.UseMiddleware<ExceptionMiddleware>();
app.MapGet("/health", () => Results.Ok());
app.Run();
```