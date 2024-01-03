using Cheetah.Domain.Entities.Dimentions;
using Microsoft.EntityFrameworkCore;

namespace Cheetah.Application.Business.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<D_Tag> D_Tags { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
