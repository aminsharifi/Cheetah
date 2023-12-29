using Cheetah.Application.Business.Repository;
using Cheetah.Domain;
using Cheetah.Domain.Entities.Facts;
using Cheetah.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Cheetah.Presentation.Services.GraphQL;

public class Mutation
{   
    #region GetTokenAsync
    
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
    
    public async Task<CheetahResult<F_Case>> CreateRequestAsync(
        [Service] IWorkItem iWorkItem,
        [Service] ApplicationDbContext _db,
        F_Case request)
    {
        return await iWorkItem.CreateRequestAsync(request);
    }
    #endregion

    #region PerformWorkItemAsync
    
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