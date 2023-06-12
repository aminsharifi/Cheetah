using Cheetah_Business.Facts;
using Cheetah_Business.Repository;
using HotChocolate;

namespace Cheetah_DataAccess.Data;

public class Mutation
{
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public async Task<F_Request> PerformRequestAsync(
        [Service] ISimpleClassRepository iSimpleClassRepository, F_Request request)
    {
        return await iSimpleClassRepository.PerformRequestAsync(request);
    }
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public async Task<F_Request> CreateRequestAsync(
        [Service] ISimpleClassRepository iSimpleClassRepository, F_Request request)
    {
        return await iSimpleClassRepository.CreateRequestAsync(request);
    }
}