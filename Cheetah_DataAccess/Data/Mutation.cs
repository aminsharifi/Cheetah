using Cheetah_Business.Facts;
using Cheetah_Business.Repository;
using HotChocolate;
using HotChocolate.Authorization;
using HotChocolate.Data;
using Microsoft.EntityFrameworkCore;

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

    #region GetTokenAsync
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    [AllowAnonymous]
    public async Task<IdentityService> GetTokenAsync(
        [Service] IIdentityService identityService,
        [Service] ITableCRUD iSimpleClassRepository,
        string email, string password)
    {
        var MyIdentityService = new IdentityService();

        MyIdentityService.AccessToken = await identityService.Authenticate(email, password);

        return MyIdentityService;
    }
    #endregion

    #region CreateRequestAsync
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    [Authorize]
    public async Task<F_Case> CreateRequestAsync(
        [Service] IWorkItem iWorkItem,
        [Service] ApplicationDbContext _db,
        F_Case request)
    {
        return await iWorkItem.CreateRequestAsync(request);
    }
    #endregion

    #region PerformWorkItemAsync
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    [Authorize]
    public async Task<F_Case> PerformWorkItemAsync(
           [Service] IWorkItem iWorkItem,
           [Service] ApplicationDbContext _db,
           F_WorkItem request)
    {
        await iWorkItem.PerformWorkItemAsync(request);

        return await _db.F_Cases.SingleAsync(x => x.Id == request.CaseId);
    }
    #endregion

}