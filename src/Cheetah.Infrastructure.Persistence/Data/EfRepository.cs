using Ardalis.SharedKernel;
using Ardalis.Specification.EntityFrameworkCore;

namespace Cheetah.Infrastructure.Persistence.Data;

// inherit from Ardalis.Specification type
public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
    public EfRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
