using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Cheetah.Infrastructure.Persistence;


public static class InitialiserExtensions
{
    public static async Task InitialiseDatabaseAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        var initialiser = scope.ServiceProvider.GetRequiredService<DbInitialiser>();

        await initialiser.InitialiseAsync();

        await initialiser.SeedAsync();
    }
}

public class DbInitialiser(ApplicationDbContext _context)
{
    public async Task<bool> InitialiseAsync()
    {
        await _context.Database.MigrateAsync();

        return true;
    }
    public async Task SeedAsync()
    {
        if (!_context.D_Processes.Any())
        {
            await _context.SaveChangesAsync();
        }
    }
}