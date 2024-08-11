using Cheetah.Core.Interfaces.WorkItem;
using Cheetah.Core.Entities.Facts;
using Cheetah.Infrastructure.Data;

namespace Cheetah.Sample.Presentation.Services.GraphQL;

public class OldMutation
{
    #region GetTokenAsync

    //public async Task<IdentityService> GetTokenAsync(
    //    [Service] IIdentityService identityService,
    //    [Service] ITableCRUD iSimpleClassRepository,
    //    string email, string password)
    //{
    //    var MyIdentityService = new IdentityService();

    //    MyIdentityService.AccessToken = await identityService.Authenticate(email, password);

    //    return MyIdentityService;
    //}
    #endregion

    #region CreateRequestAsync

    public async Task<Result<F_Case>> CreateRequestAsync(
        [Service] IWorkItem iWorkItem,
        [Service] ApplicationDbContext _db,
        F_Case request)
    {
        return new Result<F_Case>();
        //return await iWorkItem.CreateRequestAsync(request);
    }
    #endregion

    #region PerformWorkItemAsync

    public async Task<F_Case> PerformWorkItemAsync(
           [Service] IWorkItem iWorkItem,
           [Service] ApplicationDbContext _db,
           F_WorkItem request)
    {
        return new F_Case();
        //await iWorkItem.PerformWorkItemAsync(request);

        //return await _db.F_Cases.SingleAsync(x => x.Id == request.CaseId);
    }
    #endregion

}