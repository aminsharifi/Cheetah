using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using FluentAssertions.Common;
using Cheetah_DataAccess.Parameters;
using Cheetah_DataAccess.Masters;
using Cheetah_DataAccess.Systems;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Cheetah_DataAccess.Data
{
    public partial class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<BaseClass>()
        //        .Property(x => x.GuidRecord).HasDefaultValueSql("newid()");
        //}
        public virtual DbSet<P_ParameterType> P_ParameterTypes { get; set; }
        public virtual DbSet<P_ParameterList> P_ParameterLists { get; set; }
        public virtual DbSet<P_RequestTitle> P_RequestTitles { get; set; }
        public virtual DbSet<P_RequestType> P_RequestTypes { get; set; }
        public virtual DbSet<P_ProcessState> P_ProcessStates { get; set; }
        public virtual DbSet<P_SubRequestTitle> P_SubRequestTitles { get; set; }
        public virtual DbSet<P_PositionOrg> P_PositionOrgs { get; set; }
        public virtual DbSet<P_ProcessEndorsement> P_ProcessEndorsements { get; set; }
        public virtual DbSet<S_Area> S_Areas { get; set; }
        public virtual DbSet<S_Location> S_Locations { get; set; }
        public virtual DbSet<S_Role> S_Roles { get; set; }
        public virtual DbSet<S_User> S_Users { get; set; }
        public virtual DbSet<M_RequestInformation> M_RequestInformations { get; set; }
        public virtual DbSet<M_Approve> M_Approves { get; set; }
        public virtual DbSet<M_Attachment> M_Attachments { get; set; }
        public virtual DbSet<S_UserRole> S_UserRoles { get; set; }
        public virtual DbSet<M_AllApprove> M_AllApproves { get; set; }
        public virtual DbSet<P_FieldType> P_FieldTypes { get; set; }
        public virtual DbSet<P_Operand> P_Operands { get; set; }
    }
}