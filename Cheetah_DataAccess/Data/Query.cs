using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using Cheetah_Business.Facts;
using Cheetah_Business.Links;
using Cheetah_Business.Repository;
using HotChocolate;
using System.Linq;

namespace Cheetah_DataAccess.Data;

public class Query
{
    #region Dimentions

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<D_Entity> d_Entities([Service] ApplicationDbContext context)
    {
        return context.D_Entities;
    }
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<D_Tag> d_Tags([Service] ApplicationDbContext context)
    {
        return context.D_Tags;
    }
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<D_Process> d_Processes([Service] ApplicationDbContext context)
    {
        return context.D_Processes;
    }
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<D_ProcessState> d_ProcessState([Service] ApplicationDbContext context)
    {
        return context.D_ProcessStates;
    }
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<D_Position> d_Positions([Service] ApplicationDbContext context)
    {
        return context.D_Positions;
    }
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<D_Location> d_Locations([Service] ApplicationDbContext context)
    {
        return context.D_Locations;
    }
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<D_Role> d_Roles([Service] ApplicationDbContext context)
    {
        return context.D_Roles;
    }
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<D_User> d_Users([Service] ApplicationDbContext context)
    {
        return context.D_Users;
    }
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<D_Operand> d_Operands([Service] ApplicationDbContext context)
    {
        return context.D_Operands;
    }
    #endregion

    #region Facts

    #region workItemAsync
    [UseProjection]
    [UseFiltering]
    [UseSorting]
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
        //        TaskName = x.UA_Assignment.PRM_Endorsement.PDisplayName,
        //        CreateDate = x.UA_Assignment.PRM_Request.CreateTimeRecord,
        //        RecieveDate = x.UA_Assignment.CreateTimeRecord,
        //        Summary = x.UA_Assignment.PRM_Request.PDisplayName
        //    }
        //    );


        return null;
    }
    #endregion

    #region InboxAsync
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    //[Authorize]
    public IQueryable<CartableDTO> inbox(
       [Service] ApplicationDbContext context)
    {
        //.Where(x => x.UA_Assignment.PRM_Request.RQT_CurrentAssignment == x.UA_Assignment)

        var inbox = workItem(context).Where(x => x.Tag == null);

        return inbox;

    }
    #endregion

    #region OutboxAsync
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<CartableDTO> outbox(
        [Service] ApplicationDbContext context)
    {
        var Outbox = workItem(context).Where(x => x.Tag != null);
        return Outbox;
    }
    #endregion


    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<F_Scenario> f_Scenarios([Service] ApplicationDbContext context)
    {
        return context.F_Scenarios;
    }

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<F_Endorsement> f_Endorsements([Service] ApplicationDbContext context)
    {
        return context.F_Endorsements;
    }
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<F_Condition> f_Conditions([Service] ApplicationDbContext context)
    {
        return context.F_Conditions;
    }
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<F_Case> f_Requests([Service] ApplicationDbContext context)
    {
        return context.F_Cases;
    }
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<F_WorkItem> f_WorkItems([Service] ApplicationDbContext context)
    {
        return context.F_WorkItems;
    }
  
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<F_Attachment> f_Attachments([Service] ApplicationDbContext context)
    {
        return context.F_Attachments;
    }


    #endregion

    #region Links
  
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<L_RolePosition> l_RolePositions([Service] ApplicationDbContext context)
    {
        return context.L_RolePositions;
    }
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<L_UserLocation> l_UserLocations([Service] ApplicationDbContext context)
    {
        return context.L_UserLocations;
    }
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<L_UserPosition> l_UserPositions([Service] ApplicationDbContext context)
    {
        return context.L_UserPositions;
    }
    #endregion
}