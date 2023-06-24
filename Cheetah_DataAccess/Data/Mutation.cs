using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using Cheetah_Business.Facts;
using Cheetah_Business.Repository;
using HotChocolate;
using HotChocolate.Authorization;

namespace Cheetah_DataAccess.Data;

public class Mutation
{
    //[UseProjection]
    //[UseFiltering]
    //[UseSorting]
    //public async Task<string> GetTokenAsync(
    //    //[Service] IIdentityService identityService, string email, string password)
    //    string email, string password)
    //{
    //    //return await identityService.Authenticate(email, password);
    //    return email;
    //}

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    [AllowAnonymous]
    public async Task<IdentityService> GetTokenAsync(
        [Service] IIdentityService identityService,
        [Service] ISimpleClassRepository iSimpleClassRepository,
        string email, string password)
    {
        var MyIdentityService = new IdentityService();

        MyIdentityService.AccessToken = await identityService.Authenticate(email, password);

        return MyIdentityService;
    }

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    [Authorize]
    public async Task<F_Request> PerformRequestAsync(
        [Service] ISimpleClassRepository iSimpleClassRepository, F_Request request)
    {
        return await iSimpleClassRepository.PerformRequestAsync(request);
    }
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    [Authorize]
    public async Task<F_Request> CreateRequestAsync(
        [Service] ISimpleClassRepository iSimpleClassRepository, F_Request request)
    {
        return await iSimpleClassRepository.CreateRequestAsync(request);
    }
}