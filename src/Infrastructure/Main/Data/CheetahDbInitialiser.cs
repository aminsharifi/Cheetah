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
        //if (await _userManager?.Users?.AnyAsync(x=>x.UserName == "Delete"))
        //{
        //    await _db.Database.EnsureCreatedAsync();
        //}

        if (_db.Database.GetPendingMigrations().Count() > 0)
        {
            _db.Database.Migrate();
        }
        return true;
    }
}