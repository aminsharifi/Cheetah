using Cheetah.Domain.Dimentions;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Cheetah.Infrastructure.Persistence;

public partial class ApplicationDbContext : IdentityDbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        //    private readonly RoleManager<IdentityRole> _roleManager;
        //_roleManager = roleManager;

        //    if (! _roleManager.RoleExistsAsync(nameof(RoleProperty.Admin)).GetAwaiter().GetResult())
        //    {
        //        _roleManager.CreateAsync(new IdentityRole(nameof(RoleProperty.Admin)));
        //    }

        //    if (!_roleManager.RoleExistsAsync(nameof(RoleProperty.User)).GetAwaiter().GetResult())
        //    {
        //        _roleManager.CreateAsync(new IdentityRole(nameof(RoleProperty.User)));
        //    }
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder
        //    .ConfigureWarnings(warnings => warnings.Ignore(CoreEventId.DetachedLazyLoadingWarning));
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<D_Entity>()
            .Property(e => e.Display)
            .HasDefaultValue(true)
            .HasColumnOrder(100);

        builder.Entity<D_Location>()
            .Property(e => e.EndorsementItemId)
            .HasColumnOrder(110);

        #region D_Process

        builder.Entity<D_Process>()
            .Property(e => e.ShowSupport)
            .HasDefaultValue(true)
            .HasColumnOrder(110);

        builder.Entity<D_Process>()
            .Property(e => e.ERP)
            .HasDefaultValue(true)
            .HasColumnOrder(101);

        builder.Entity<D_Process>()
            .Property(e => e.RemoveRequestorApproval)
            .HasDefaultValue(true)
            .HasColumnOrder(102);

        #endregion

        #region D_Role

        builder.Entity<D_Role>()
         .Property(e => e.Independent)
         .HasDefaultValue(false)
         .HasColumnOrder(100);

        builder.Entity<D_Role>()
         .Property(e => e.FixedRole)
         .HasDefaultValue(false)
         .HasColumnOrder(101);

        #endregion

        #region D_Tag

        builder.Entity<D_Tag>()
            .Property(e => e.TagTypeId)
            .HasColumnOrder(100);

        #endregion

        #region D_User

        #region Simple Prob

        builder.Entity<D_User>()
            .Property(e => e.Domain)
            .HasColumnOrder(102)
            .HasMaxLength(25);

        builder.Entity<D_User>()
            .Property(e => e.EnabledForAssignation)
            .HasColumnOrder(103)
            .HasDefaultValue(true);

        builder.Entity<D_User>()
            .Property(e => e.DelegateEnabled)
            .HasColumnOrder(104)
            .HasDefaultValue(false);

        builder.Entity<D_User>()
            .Property(e => e.CreatedCasesSkipAssigRules)
            .HasColumnOrder(105)
            .HasDefaultValue(false);

        builder.Entity<D_User>()
            .Property(e => e.IDPersonel)
            .HasColumnOrder(106)
            .HasMaxLength(10);

        builder.Entity<D_User>()
            .Property(e => e.LDAPDescription)
            .HasColumnOrder(107)
            .HasMaxLength(20);

        #endregion

        #region Entity   

        #region S_User

        builder.Entity<D_User>()
            .Property(e => e.DelegateId)
            .HasColumnOrder(109);

        builder.Entity<D_User>()
            .Property(e => e.UserInformationId)
            .HasColumnOrder(110);
        #endregion

        #endregion

        #endregion

        #region D_UserInformation

        builder.Entity<D_UserInformation>()
          .Property(e => e.FirstName)
          .HasColumnOrder(100)
          .HasMaxLength(50);

        builder.Entity<D_UserInformation>()
          .Property(e => e.LastName)
          .HasColumnOrder(101)
          .HasMaxLength(50);


        builder.Entity<D_UserInformation>()
          .Property(e => e.NotifByEmail)
          .HasColumnOrder(102);


        builder.Entity<D_UserInformation>()
          .Property(e => e.NotifByMessenger)
          .HasColumnOrder(103);


        builder.Entity<D_UserInformation>()
          .Property(e => e.NotifByCell)
          .HasColumnOrder(104);


        builder.Entity<D_UserInformation>()
          .Property(e => e.ContactEmail)
          .HasColumnOrder(105)
          .HasMaxLength(100);


        builder.Entity<D_UserInformation>()
          .Property(e => e.ContactMessenger)
          .HasColumnOrder(106)
          .HasMaxLength(100);


        builder.Entity<D_UserInformation>()
          .Property(e => e.ContactCell)
          .HasColumnOrder(107)
          .HasMaxLength(20);

        builder.Entity<D_UserInformation>()
          .Property(e => e.UserPicture)
          .HasColumnOrder(108);

        builder.Entity<D_UserInformation>()
          .Property(e => e.NationalCode)
          .HasColumnOrder(109)
          .HasMaxLength(20);

        builder.Entity<D_UserInformation>()
          .Property(e => e.Birthdate)
          .HasColumnOrder(110);

        builder.Entity<D_UserInformation>()
          .Property(e => e.InternalPhone)
          .HasColumnOrder(111)
          .HasMaxLength(50);

        builder.Entity<D_UserInformation>()
          .Property(e => e.Address)
          .HasColumnOrder(112)
          .HasMaxLength(512);

        builder.Entity<D_UserInformation>()
          .Property(e => e.RegistrationNumber)
          .HasColumnOrder(113)
          .HasMaxLength(215);

        #endregion

        foreach (var entityType in builder.Model.GetEntityTypes())
        {
            if (Enum.IsDefined(typeof(TableType), entityType.ClrType.Namespace.Split('.').Last()))
            {
                entityType.SetTableName(entityType.ClrType.Name);
                entityType.SetSchema(entityType.ClrType.Namespace.Split('.').Last());
            }
        }

        builder.ApplyBaseEntityConfiguration();

        //base.Database.EnsureDeleted();
        //base.Database.EnsureCreated();
        base.OnModelCreating(builder);

        builder.Seed();
    }

    #region Dimentions
    public virtual DbSet<D_Entity> D_Entities { get; set; }
    public virtual DbSet<D_Tag> D_Tags { get; set; }
    public virtual DbSet<D_Process> D_Processes { get; set; }
    public virtual DbSet<D_CaseState> D_CaseStates { get; set; }
    public virtual DbSet<D_Position> D_Positions { get; set; }
    public virtual DbSet<D_Location> D_Locations { get; set; }
    public virtual DbSet<D_Role> D_Roles { get; set; }
    public virtual DbSet<D_User> D_Users { get; set; }
    public virtual DbSet<D_Operand> D_Operands { get; set; }
    public virtual DbSet<D_WorkItemState> D_WorkItemStates { get; set; }

    #endregion

    #region Facts
    public virtual DbSet<F_Endorsement> F_Endorsements { get; set; }
    public virtual DbSet<F_Condition> F_Conditions { get; set; }
    public virtual DbSet<F_Case> F_Cases { get; set; }
    public virtual DbSet<F_WorkItem> F_WorkItems { get; set; }
    public virtual DbSet<F_Attachment> F_Attachments { get; set; }
    public virtual DbSet<F_Scenario> F_Scenarios { get; set; }
    public virtual DbSet<F_EndorsementItem> F_EndorsementItems { get; set; }

    #endregion

    #region Links
    public virtual DbSet<L_RolePosition> L_RolePositions { get; set; }
    public virtual DbSet<L_UserLocation> L_UserLocations { get; set; }
    public virtual DbSet<L_UserPosition> L_UserPositions { get; set; }
    public virtual DbSet<L_ProcessScenario> L_ProcessScenarios { get; set; }

    #endregion
    public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
}