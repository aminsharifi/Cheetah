﻿namespace Cheetah.Infrastructure.Persistence;

public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ConfigureSimpleClass();

        builder = builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        var _entityValues = GetEntity.Values();

        foreach (var filedInfos in _entityValues)
        {
            foreach (var filedInfo in filedInfos)
            {
                var simpleClass = filedInfo.GetValue(null) as BaseEntity;

                if (simpleClass == null)
                {
                    var aa = 12;
                }

                builder.Entity(simpleClass.GetType()).HasData(simpleClass);
            }
        }

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
    public virtual DbSet<D_User> D_Users { get; set; }
    public virtual DbSet<D_Operand> D_Operands { get; set; }
    public virtual DbSet<D_WorkItemState> D_WorkItemStates { get; set; }
    public virtual DbSet<D_TagType> D_TagTypes { get; set; }

    #endregion

    #region Facts
    public virtual DbSet<F_Task> F_Tasks { get; set; }
    public virtual DbSet<F_Condition> F_Conditions { get; set; }
    public virtual DbSet<F_Case> F_Cases { get; set; }
    public virtual DbSet<F_WorkItem> F_WorkItems { get; set; }
    public virtual DbSet<F_Attachment> F_Attachments { get; set; }
    public virtual DbSet<F_Scenario> F_Scenarios { get; set; }
    public virtual DbSet<F_Flow> F_Flows { get; set; }

    #endregion

    #region Links
    public virtual DbSet<L_ProcessScenario> L_ProcessScenarios { get; set; }
    public virtual DbSet<L_TaskFlow> L_TaskFlows { get; set; }
    public virtual DbSet<L_FlowTask> L_FlowTasks { get; set; }
    public virtual DbSet<L_TaskCondition> L_TaskConditions { get; set; }    
    public virtual DbSet<L_CaseTaskUser> L_CaseTaskUsers { get; set; }
    public virtual DbSet<L_UserCondition> L_UserConditions { get; set; }
    
    #endregion

    #endregion
}