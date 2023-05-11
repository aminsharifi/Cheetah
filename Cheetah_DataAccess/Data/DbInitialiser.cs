using Microsoft.EntityFrameworkCore;

namespace Cheetah_DataAccess.Data
{
    public class DbInitialiser
    {
        private readonly ApplicationDbContext _context;

        public DbInitialiser(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Run()
        {
            _context.Database.Migrate();
        }
    }
}
