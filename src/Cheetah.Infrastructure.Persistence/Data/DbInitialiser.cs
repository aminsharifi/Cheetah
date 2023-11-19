namespace Cheetah.Infrastructure.Persistence;

public class DbInitialiser(ApplicationDbContext _context)
{
    public async Task<bool> Run()
    {
        //await _context.Database.EnsureDeletedAsync();

        //await _context.Database.MigrateAsync();

        return true;
    }
}