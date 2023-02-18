using Cheetah_Business.Repository.IRepository;
using Cheetah_Business.Repository.IRepository.General;
using Cheetah_DataAccess.Data;
using Cheetah_DataAccess.Parameters;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

builder.Services.AddDbContext<ApplicationDbContext>(
    b => b.UseLazyLoadingProxies()
          .UseSqlServer(builder.Configuration.GetConnectionString("CheetahConnection")));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<IGeneralRepository<P_ParameterList>, P_ParameterListRepository>();

builder.Services.AddScoped<IProcessRepository, ProcessRepository>();

builder.Services.AddCors(o => o.AddPolicy("Cheetah", builder =>
{
    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
}));
var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseCors("Cheetah");

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();