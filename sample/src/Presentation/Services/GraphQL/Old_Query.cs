using Cheetah.Core.Aggregates.CaseAggregate.Dimentions;
using Cheetah.Core.Aggregates.CaseAggregate.Facts;
using Cheetah.Core.Aggregates.Common.Dimentions;
using Cheetah.Core.Aggregates.ConditionAggregate.Dimentions;
using Cheetah.Core.Aggregates.ConditionAggregate.Facts;
using Cheetah.Core.Aggregates.ProcessAggregate.Dimentions;
using Cheetah.Core.Aggregates.ProcessAggregate.Facts;
using Cheetah.Core.Aggregates.UserAggregate.Dimentions;
using Cheetah.Core.Aggregates.UserAggregate.Links;
using Cheetah.Core.Interfaces.Cartable.DTOs;
using Cheetah.Infrastructure.Data;

namespace Cheetah.Sample.Presentation.Services.GraphQL;

public class Old_Query
{
    #region Dimentions

    public IQueryable<D_Entity> d_Entities([Service] CheetahDbContext context)
    {
        return context.D_Entities;
    }

    public IQueryable<D_Tag> d_Tags([Service] CheetahDbContext context)
    {
        return context.D_Tags;
    }

    public IQueryable<D_Process> d_Processes([Service] CheetahDbContext context)
    {
        return context.D_Processes;
    }

    public IQueryable<D_CaseState> d_CaseStates([Service] CheetahDbContext context)
    {
        return context.D_CaseStates;
    }


    public IQueryable<D_User> d_Users([Service] CheetahDbContext context)
    {
        return context.D_Users;
    }

    public IQueryable<D_Operand> d_Operands([Service] CheetahDbContext context)
    {
        return context.D_Operands;
    }
    #endregion

    #region Facts

    #region workItemAsync

    public IQueryable<CartableDTO> workItem(
        [Service] CheetahDbContext context)
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
       [Service] CheetahDbContext context)
    {
        var inbox = workItem(context).Where(x => !x.OccurredUserActions.Any());
        return inbox;
    }
    #endregion

    #region OutboxAsync

    public IQueryable<CartableDTO> outbox(
        [Service] CheetahDbContext context)
    {
        var Outbox = workItem(context).Where(x => !x.OccurredUserActions.Any());
        return Outbox;
    }
    #endregion


    public IQueryable<F_Scenario> f_Scenarios([Service] CheetahDbContext context)
    {
        return context.F_Scenarios;
    }

    public IQueryable<F_Task> f_Tasks([Service] CheetahDbContext context)
    {
        return context.F_Tasks;
    }

    public IQueryable<F_Condition> f_Conditions([Service] CheetahDbContext context)
    {
        return context.F_Conditions;
    }

    public IQueryable<F_Case> f_Requests([Service] CheetahDbContext context)
    {
        return context.F_Cases;
    }

    public IQueryable<F_WorkItem> f_WorkItems([Service] CheetahDbContext context)
    {
        return context.F_WorkItems;
    }

    #endregion

    #region Links

    public IQueryable<L_UserCondition> l_UserConditions([Service] CheetahDbContext context)
    {
        return context.L_UserConditions;
    }
    #endregion
}