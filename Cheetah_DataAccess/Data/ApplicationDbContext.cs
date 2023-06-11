using Cheetah_Business.Dimentions;
using Cheetah_Business.Facts;
using Cheetah_Business.Links;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cheetah_DataAccess.Data
{
    public partial class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //base.Database.EnsureDeleted();
            base.Database.EnsureCreated();

            base.OnModelCreating(builder);
            //builder.Seed();
        }

        #region Dimentions
        public virtual DbSet<D_Entity> D_Entities { get; set; }
        public virtual DbSet<D_Tag> D_Tags { get; set; }
        public virtual DbSet<D_Process> D_Processes { get; set; }
        public virtual DbSet<D_ProcessState> D_ProcessStates { get; set; }
        public virtual DbSet<D_Position> D_Positions { get; set; }                     
        public virtual DbSet<D_Location> D_Locations { get; set; }
        public virtual DbSet<D_Role> D_Roles { get; set; }
        public virtual DbSet<D_User> D_Users { get; set; }
        public virtual DbSet<D_Operand> D_Operands { get; set; }
        #endregion

        #region Facts
        public virtual DbSet<F_Endorsement> F_Endorsements { get; set; }
        public virtual DbSet<F_Condition> F_Conditions { get; set; }
        public virtual DbSet<F_Request> F_Requests { get; set; }
        public virtual DbSet<F_Assignment> F_Assignments { get; set; }
        public virtual DbSet<F_Review> F_Reviews { get; set; }
        public virtual DbSet<F_Attachment> F_Attachments { get; set; }
        public virtual DbSet<F_Scenario> F_Scenarios { get; set; }

        #endregion

        #region Links
        public virtual DbSet<L_RolePosition> L_RolePositions { get; set; }
        public virtual DbSet<L_UserLocation> L_UserLocations { get; set; }
        public virtual DbSet<L_UserPosition> L_UserPositions { get; set; }
        public virtual DbSet<L_UserAssignment> L_UserAssignments { get; set; }
        #endregion

    }
}