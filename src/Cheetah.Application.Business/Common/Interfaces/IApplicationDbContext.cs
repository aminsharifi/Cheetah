namespace Cheetah.Application.Business.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Cheetah.Domain.Entities.Dimentions.D_Tag> D_Tags { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
