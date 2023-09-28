namespace Cheetah.Infrastructure.Persistence;

public class DbInitialiser
{
    private readonly ApplicationDbContext _context;

    public DbInitialiser(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Run()
    {
        //await _context.Database.EnsureDeletedAsync();

        //await _context.Database.MigrateAsync();

        return true;
    }
}