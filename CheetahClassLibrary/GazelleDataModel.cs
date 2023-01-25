using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CheetahClassLibrary
{
    public partial class GazelleDataModel : DbContext
    {
        public GazelleDataModel()
            : base("name=GazelleDataModel")
        {
        }

        public virtual DbSet<Approve> Approves { get; set; }
        public virtual DbSet<AREA> AREAs { get; set; }
        public virtual DbSet<CallWebService> CallWebServices { get; set; }
        public virtual DbSet<CurrentProcessEndorseman> CurrentProcessEndorsemen { get; set; }
        public virtual DbSet<LOCATION> LOCATIONs { get; set; }
        public virtual DbSet<ORGPOSITION> ORGPOSITIONs { get; set; }
        public virtual DbSet<OrgPosition1> OrgPositions1 { get; set; }
        public virtual DbSet<ParameterList> ParameterLists { get; set; }
        public virtual DbSet<ParameterType> ParameterTypes { get; set; }
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AREA>()
                .Property(e => e.costArea)
                .HasPrecision(11, 2);

            modelBuilder.Entity<CurrentProcessEndorseman>()
                .HasOptional(e => e.RequestInformation1)
                .WithRequired(e => e.CurrentProcessEndorseman);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.costLocation)
                .HasPrecision(11, 2);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.ancestorPath)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .HasMany(e => e.LOCATION1)
                .WithOptional(e => e.LOCATION2)
                .HasForeignKey(e => e.idParentLocation);

            modelBuilder.Entity<ORGPOSITION>()
                .Property(e => e.costPosition)
                .HasPrecision(11, 2);

            modelBuilder.Entity<ORGPOSITION>()
                .Property(e => e.ancestorPath)
                .IsUnicode(false);

            modelBuilder.Entity<ORGPOSITION>()
                .HasMany(e => e.ORGPOSITION1)
                .WithOptional(e => e.ORGPOSITION2)
                .HasForeignKey(e => e.idParentPosition);

            modelBuilder.Entity<ParameterType>()
                .HasMany(e => e.ParameterLists)
                .WithOptional(e => e.ParameterType1)
                .HasForeignKey(e => e.ParameterType);

            modelBuilder.Entity<ProcessEndorsement>()
                .HasMany(e => e.CurrentProcessEndorsemen)
                .WithOptional(e => e.ProcessEndorsement)
                .HasForeignKey(e => e.RequestInformation);

            modelBuilder.Entity<RequestInformation>()
                .HasMany(e => e.Approves)
                .WithOptional(e => e.RequestInformation1)
                .HasForeignKey(e => e.RequestInformation);

            modelBuilder.Entity<RequestInformation>()
                .HasMany(e => e.CallWebServices)
                .WithOptional(e => e.RequestInformation1)
                .HasForeignKey(e => e.RequestInformation);

            modelBuilder.Entity<RequestInformation>()
                .HasMany(e => e.UserActionsProcesses)
                .WithOptional(e => e.RequestInformation1)
                .HasForeignKey(e => e.RequestInformation);

            modelBuilder.Entity<RequestTitle>()
                .HasMany(e => e.ProcessEndorsements)
                .WithOptional(e => e.RequestTitle)
                .HasForeignKey(e => e.PE_RequestTitles);

            modelBuilder.Entity<RequestTitle>()
                .HasMany(e => e.SubRequestTitles)
                .WithOptional(e => e.RequestTitle)
                .HasForeignKey(e => e.RequestTitles);

            modelBuilder.Entity<RI_ProcessState>()
                .HasMany(e => e.ProcessEndorsements)
                .WithOptional(e => e.RI_ProcessState)
                .HasForeignKey(e => e.PE_ProcessState);

            modelBuilder.Entity<ROLE>()
                .HasMany(e => e.OrgPositions)
                .WithOptional(e => e.ROLE)
                .HasForeignKey(e => e.OrgPositions_Role);

            modelBuilder.Entity<ROLE>()
                .HasMany(e => e.OrgPositions1)
                .WithOptional(e => e.ROLE1)
                .HasForeignKey(e => e.OrgPositions_Role2);

            modelBuilder.Entity<UserAction>()
                .HasMany(e => e.Approves)
                .WithOptional(e => e.UserAction)
                .HasForeignKey(e => e.Approves_UserAction);

            modelBuilder.Entity<UserAction>()
                .HasMany(e => e.CurrentProcessEndorsemen)
                .WithOptional(e => e.UserAction)
                .HasForeignKey(e => e.CU_UserAction);

            modelBuilder.Entity<UserActionGroup>()
                .HasMany(e => e.UserActions)
                .WithOptional(e => e.UserActionGroup1)
                .HasForeignKey(e => e.UserActionGroup);

            modelBuilder.Entity<UserActionsProcess>()
                .HasMany(e => e.CurrentProcessEndorsemen1)
                .WithOptional(e => e.UserActionsProcess1)
                .HasForeignKey(e => e.UserActionsProcess);

            modelBuilder.Entity<WFUSER>()
                .Property(e => e.userName)
                .IsUnicode(false);

            modelBuilder.Entity<WFUSER>()
                .Property(e => e.normalCost20220308_235415_0)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WFUSER>()
                .Property(e => e.overtimeCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WFUSER>()
                .Property(e => e.normalCost20220606_155503_0)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WFUSER>()
                .Property(e => e.normalCost20220613_153951_0)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WFUSER>()
                .Property(e => e.normalCost20220704_113058_0)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WFUSER>()
                .Property(e => e.normalCost20220725_114415_0)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WFUSER>()
                .Property(e => e.normalCost20220801_151831_0)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WFUSER>()
                .Property(e => e.normalCost20221008_120219_0)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WFUSER>()
                .Property(e => e.normalCost20221119_115603_0)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WFUSER>()
                .Property(e => e.normalCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WFUSER>()
                .HasMany(e => e.Approves)
                .WithOptional(e => e.WFUSER)
                .HasForeignKey(e => e.Approves_UserInCharge);

            modelBuilder.Entity<WFUSER>()
                .HasMany(e => e.CurrentProcessEndorsemen)
                .WithOptional(e => e.WFUSER)
                .HasForeignKey(e => e.CU_User);

            modelBuilder.Entity<WFUSER>()
                .HasMany(e => e.WFUSER1)
                .WithOptional(e => e.WFUSER2)
                .HasForeignKey(e => e.idBossUser);

            modelBuilder.Entity<WFUSER>()
                .HasMany(e => e.WFUSER11)
                .WithOptional(e => e.WFUSER3)
                .HasForeignKey(e => e.idDelegate);
        }
    }
}
