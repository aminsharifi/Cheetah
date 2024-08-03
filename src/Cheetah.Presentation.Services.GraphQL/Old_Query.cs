using Cheetah.Domain.Aggregates.UserAggregate.Links;
using Cheetah.Domain.Entities.Dimentions;
using Cheetah.Domain.Entities.Facts;
using Cheetah.Domain.Interfaces.Cartable.DTOs;
using Cheetah.Infrastructure.Persistence.Data;

namespace Cheetah.Presentation.Services.GraphQL;

public class Old_Query
{
    #region Dimentions

    public IQueryable<D_Entity> d_Entities([Service] ApplicationDbContext context)
    {
        return context.D_Entities;
    }

    public IQueryable<D_Tag> d_Tags([Service] ApplicationDbContext context)
    {
        return context.D_Tags;
    }

    public IQueryable<D_Process> d_Processes([Service] ApplicationDbContext context)
    {
        return context.D_Processes;
    }

    public IQueryable<D_CaseState> d_CaseStates([Service] ApplicationDbContext context)
    {
        return context.D_CaseStates;
    }


    public IQueryable<D_User> d_Users([Service] ApplicationDbContext context)
    {
        return context.D_Users;
    }

    public IQueryable<D_Operand> d_Operands([Service] ApplicationDbContext context)
    {
        return context.D_Operands;
    }
    #endregion

    #region Facts

    #region workItemAsync

    public IQueryable<CartableDTO> workItem(
        [Service] ApplicationDbContext context)
    {
        //var Outbox = context.L_UserAssignments
        //    .Select(x =>
        //    new CartableDTO()
        //    {
        //        Tag = x.UA_Assignment.PRM_Review.APV_Tag,
        //        Username = x.UA_User.PName,
        //        ProcessName = x.UA_Assignment.PRM_Request.RQT_Process.PDisplayName,
        //        RadNumber = x.UA_Assignment.PRM_RequestId.ToString(),
        //        Requestor = x.UA_Assignment.PRM_Request.RQT_Requestor.PDisplayName,
        //        TaskName = x.UA_Assignment.PRM_Task.PDisplayName,
        //        CreateDate = x.UA_Assignment.PRM_Request.CreateTimeRecord,
        //        RecieveDate = x.UA_Assignment.CreateTimeRecord,
        //        Summary = x.UA_Assignment.PRM_Request.PDisplayName
        //    }
        //    );


        return null;
    }
    #endregion

    #region InboxAsync

    //[Authorize]
    public IQueryable<CartableDTO> inbox(
       [Service] ApplicationDbContext context)
    {
        var inbox = workItem(context).Where(x => !x.OccurredUserActions.Any());
        return inbox;
    }
    #endregion

    #region OutboxAsync

    public IQueryable<CartableDTO> outbox(
        [Service] ApplicationDbContext context)
    {
        var Outbox = workItem(context).Where(x => !x.OccurredUserActions.Any());
        return Outbox;
    }
    #endregion


    public IQueryable<F_Scenario> f_Scenarios([Service] ApplicationDbContext context)
    {
        return context.F_Scenarios;
    }

    public IQueryable<F_Task> f_Tasks([Service] ApplicationDbContext context)
    {
        return context.F_Tasks;
    }

    public IQueryable<F_Condition> f_Conditions([Service] ApplicationDbContext context)
    {
        return context.F_Conditions;
    }

    public IQueryable<F_Case> f_Requests([Service] ApplicationDbContext context)
    {
        return context.F_Cases;
    }

    public IQueryable<F_WorkItem> f_WorkItems([Service] ApplicationDbContext context)
    {
        return context.F_WorkItems;
    }

    #endregion

    #region Links

    public IQueryable<L_UserCondition> l_UserConditions([Service] ApplicationDbContext context)
    {
        return context.L_UserConditions;
    }
    #endregion
}