using Cheetah_Business.Dimentions;
using Cheetah_Business.Facts;
using Cheetah_Business.Links;
using HotChocolate;

namespace Cheetah_DataAccess.Data
{
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
        public IQueryable<F_Request> f_Requests([Service] ApplicationDbContext context)
        {
            return context.F_Requests;
        }
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<F_AllReview> f_AllReviews([Service] ApplicationDbContext context)
        {
            return context.F_AllReviews;
        }
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<F_Review> f_Reviews([Service] ApplicationDbContext context)
        {
            return context.F_Reviews;
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
}
