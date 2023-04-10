using Cheetah_DataAccess.Dimentions;
using Cheetah_DataAccess.Links;
using Cheetah_DataAccess.Facts;
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
            base.OnModelCreating(builder);
            builder.Seed();
        }

        #region Dimentions
        public virtual DbSet<D_ParameterType> P_ParameterTypes { get; set; }
        public virtual DbSet<D_ParameterList> P_ParameterLists { get; set; }
        public virtual DbSet<D_RequestTitle> P_RequestTitles { get; set; }
        public virtual DbSet<D_ProcessState> P_ProcessStates { get; set; }
        public virtual DbSet<D_Position> P_PositionOrgs { get; set; }
        public virtual DbSet<D_ProcessEndorsement> D_ProcessEndorsements { get; set; }
        public virtual DbSet<D_Entity> D_Entities { get; set; }
        public virtual DbSet<D_Area> D_Areas { get; set; }
        public virtual DbSet<D_Location> D_Locations { get; set; }
        public virtual DbSet<D_Role> D_Roles { get; set; }
        public virtual DbSet<D_User> D_Users { get; set; }
        public virtual DbSet<D_FieldType> D_FieldTypes { get; set; }
        public virtual DbSet<D_Operand> D_Operands { get; set; }
        #endregion

        #region Facts
        public virtual DbSet<F_RequestInformation> F_RequestInformations { get; set; }
        public virtual DbSet<F_Approve> F_Approves { get; set; }
        public virtual DbSet<F_Attachment> F_Attachments { get; set; }
        public virtual DbSet<F_AllApprove> F_AllApproves { get; set; }
        public virtual DbSet<F_Endorsement> F_Endorsements { get; set; }
        #endregion

        #region Links
        public virtual DbSet<L_RolePosition> L_RolePositions { get; set; }
        public virtual DbSet<L_UserArea> L_UserAreas { get; set; }
        public virtual DbSet<L_UserLocation> L_UserLocations { get; set; }
        public virtual DbSet<L_UserPosition> L_UserPositions { get; set; }
        #endregion

    }
}