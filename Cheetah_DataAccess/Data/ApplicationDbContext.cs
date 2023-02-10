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
        //    modelBuilder.ForNpgsqlHasEnum<SomeEnum>();
        //    modelBuilder.Entity<Blog>().ToTable("blog");
        //}

        public virtual DbSet<CopyROLE> CopyROLEs { get; set; }
        public virtual DbSet<CopyProduct> CopyProducts { get; set; }
        public virtual DbSet<P_ParameterType> P_ParameterTypes { get; set; }
        public virtual DbSet<P_ParameterList> P_ParameterLists { get; set; }
        public virtual DbSet<P_RequestTitle> P_RequestTitles { get; set; }
        public virtual DbSet<P_RequestType> P_RequestTypes { get; set; }
        public virtual DbSet<P_ProcessState> P_ProcessStates { get; set; }
        public virtual DbSet<P_SubRequestTitle> P_SubRequestTitles { get; set; }
        public virtual DbSet<P_UserAction> P_UserActions { get; set; }
        public virtual DbSet<P_UserActionGroup> P_UserActionGroups { get; set; }
        public virtual DbSet<P_PositionOrg> P_PositionOrgs { get; set; }
        public virtual DbSet<P_ProcessEndorsement> P_ProcessEndorsements { get; set; }
        public virtual DbSet<S_Area> S_Areas { get; set; }
        public virtual DbSet<S_OrgPosition> S_OrgPositions { get; set; }
        public virtual DbSet<S_Location> S_Locations { get; set; }
        public virtual DbSet<S_Role> S_Roles { get; set; }
        public virtual DbSet<S_User> S_Users { get; set; }        
        public virtual DbSet<M_RequestInformation> M_RequestInformations { get; set; }
        public virtual DbSet<M_CallWebService> M_CallWebServices { get; set; }
        public virtual DbSet<M_UserActionsProcess> M_UserActionsProcesses { get; set; }
        public virtual DbSet<M_CurrentPE> M_CurrentPEs { get; set; }
        public virtual DbSet<M_Approve> M_Approves { get; set; }        
        public virtual DbSet<M_Attachment> M_Attachments { get; set; }
        public virtual DbSet<P_Person> P_Persons { get; set; }        
        public virtual DbSet<P_UnitType> UnitTypes { get; set; }
    }
}