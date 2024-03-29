namespace Cheetah.Infrastructure.Persistence.Data;

// inherit from Ardalis.Specification type
public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
    private readonly IMemoryCache _cache;
    private MemoryCacheEntryOptions _cacheOptions;
    public EfRepository(IMemoryCache cache, ApplicationDbContext dbContext) : base(dbContext)
    {
        _cache = cache;
        _cacheOptions = new MemoryCacheEntryOptions()
         .SetAbsoluteExpiration(relative: TimeSpan.FromHours(1));
    }
    public async Task<T?> FirstOrDefaultAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
    {
        if (specification.CacheEnabled)
        {
            string key = $"{specification.CacheKey}-FirstOrDefaultAsync";

            return await _cache.GetOrCreate(key, entry =>
            {
                entry.SetOptions(_cacheOptions);
                return ApplySpecification(specification).FirstOrDefaultAsync(cancellationToken);
            });
        }

        return await ApplySpecification(specification).FirstOrDefaultAsync(cancellationToken);
    }
    public async Task<TResult?> FirstOrDefaultAsync<TResult>(ISpecification<T, TResult> specification, CancellationToken cancellationToken = default)
    {
        if (specification.CacheEnabled)
        {
            string key = $"{specification.CacheKey}-FirstOrDefaultAsync";

            return await _cache.GetOrCreate(key, entry =>
            {
                entry.SetOptions(_cacheOptions);
                return ApplySpecification(specification).FirstOrDefaultAsync(cancellationToken);
            });
        }
        return await ApplySpecification(specification).FirstOrDefaultAsync(cancellationToken);
    }
    /// <inheritdoc/>
    public async Task<List<T>> ListAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
    {
        if (specification.CacheEnabled)
        {
            string key = $"{specification.CacheKey}-FirstOrDefaultAsync";

            List<T> _result;

            if (!_cache.TryGetValue(key, out _result))
            {
                var queryResultCache = await ApplySpecification(specification).ToListAsync(cancellationToken);

                _result =  specification.PostProcessingAction == null ? queryResultCache : specification.PostProcessingAction(queryResultCache).ToList();

                _cache.Set(key, _result);
            }

            return _result;
        }

        var queryResult = await ApplySpecification(specification).ToListAsync(cancellationToken);

        return specification.PostProcessingAction == null ? queryResult : specification.PostProcessingAction(queryResult).ToList();
    }
}
