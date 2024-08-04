using Cheetah.Core.Common;
using Cheetah.Core.Helpers;

namespace Cheetah.Infrastructure.Data;

// inherit from Ardalis.Specification type
public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
    private readonly IMemoryCache _cache;
    private MemoryCacheEntryOptions _cacheOptions;
    public EfRepository(IMemoryCache cache, ApplicationDbContext dbContext) : base(dbContext)
    {
        _cache = cache;
        _cacheOptions = new MemoryCacheEntryOptions()
         .SetAbsoluteExpiration(relative: TimeSpan.FromSeconds(1));
    }
    public async Task<T?> FirstOrDefaultAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
    {
        if (specification.CacheEnabled)
        {
            string key = $"SpecCache-{specification.CacheKey}";

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
            string key = $"SpecCache-{specification.CacheKey}";

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
            string key = $"SpecCache-{specification.CacheKey}";

            List<T> _result;

            if (!_cache.TryGetValue(key, out _result))
            {
                var queryResultCache = await ApplySpecification(specification).ToListAsync(cancellationToken);

                _result = specification.PostProcessingAction == null ? queryResultCache : specification.PostProcessingAction(queryResultCache).ToList();

                try
                {
                    var _startIndex = specification.CacheKey.IndexOf("-+");
                    if (_startIndex > 0)
                    {
                        var _len = specification.CacheKey.Length;
                        var _ids = specification.CacheKey.Remove(0, _startIndex + 1).FromString();
                        var _key = specification.CacheKey.Remove(_startIndex, _len - _startIndex);

                        foreach (var _id in _ids)
                        {
                            foreach (var item in _result)
                            {
                                if ((item as BaseEntity).Id == _id)
                                {
                                    var _value = item as BaseEntity;
                                    var aaaa = _key + "-" + _id;
                                    _cache.Set(_key + "-" + _id, _value);
                                }
                            }
                        }
                    }
                    else
                    {
                        _cache.Set(key, _result);
                    }
                }
                catch (Exception ex)
                {

                }
            }

            return _result;
        }

        var queryResult = await ApplySpecification(specification).ToListAsync(cancellationToken);

        return specification.PostProcessingAction == null ? queryResult : specification.PostProcessingAction(queryResult).ToList();
    }
}
