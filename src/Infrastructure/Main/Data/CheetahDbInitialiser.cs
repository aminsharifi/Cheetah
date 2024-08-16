namespace Cheetah.Infrastructure.Data;

public interface ICheetahDbInitialiser
{
    Task<bool> Initialize();
}
public class CheetahDbInitialiser : ICheetahDbInitialiser
{
    public readonly CheetahDbContext _db;
    public CheetahDbInitialiser(CheetahDbContext db)
    {
        _db = db;
    }

    public async Task<bool> Initialize()
    {
        if (_db.Database.GetPendingMigrations().Count() > 0)
        {
            _db.Database.Migrate();
        }
        return true;
    }
}