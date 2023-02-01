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

namespace Cheetah_DataAccess.Data
{
    public partial class ApplicationDbContext : DbContext
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
        public virtual DbSet<P_ParameterList> P_ParameterList { get; set; }
        public virtual DbSet<M_CallWebService> M_CallWebService { get; set; }
        

        /*
        public virtual DbSet<Approve> Approves { get; set; }
        public virtual DbSet<AREA> AREAs { get; set; }
        public virtual DbSet<CallWebService> CallWebServices { get; set; }
        public virtual DbSet<CurrentProcessEndorseman> CurrentProcessEndorsemen { get; set; }
        public virtual DbSet<LOCATION> LOCATIONs { get; set; }
        public virtual DbSet<ORGPOSITION> ORGPOSITIONs { get; set; }
        public virtual DbSet<OrgPosition1> OrgPositions1 { get; set; }
        public virtual DbSet<ParameterList> ParameterLists { get; set; }
        
        public virtual DbSet<ProcessEndorsement> ProcessEndorsements { get; set; }
        public virtual DbSet<RequestInformation> RequestInformations { get; set; }
        public virtual DbSet<RequestTitle> RequestTitles { get; set; }
        public virtual DbSet<RequestType> RequestTypes { get; set; }
        public virtual DbSet<RI_ProcessState> RI_ProcessState { get; set; }
        public virtual DbSet<ROLE> ROLEs { get; set; }
        public virtual DbSet<SubRequestTitle> SubRequestTitles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UserAction> UserActions { get; set; }
        public virtual DbSet<UserActionGroup> UserActionGroups { get; set; }
        public virtual DbSet<UserActionsProcess> UserActionsProcesses { get; set; }
        public virtual DbSet<WFUSER> WFUSERs { get; set; }
        */
    }
}