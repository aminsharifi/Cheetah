﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ConfigureSimpleClass();

        builder = builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
    }

    #region DbSets

    #region Identities
    public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }

    #endregion

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

    public virtual DbSet<D_TagType> D_TagTypes { get; set; }

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
    public virtual DbSet<L_EndorsementItemEndorsement> L_EndorsementItemEndorsements { get; set; }

    #endregion

    #endregion
}