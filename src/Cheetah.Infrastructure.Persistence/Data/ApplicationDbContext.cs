using Cheetah.Domain.Aggregates.ProcessAggregate.Links.TaskCondition;

namespace Cheetah.Infrastructure.Persistence;
public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
{
    private readonly IDomainEventDispatcher? _dispatcher;
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IDomainEventDispatcher? dispatcher) : base(options)
    {

        _dispatcher = dispatcher;
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ConfigureSimpleClass(Database);

        builder = builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        var _entityValues = GetEntity.Values();

        foreach (var filedInfos in _entityValues)
        {
            foreach (var filedInfo in filedInfos)
            {
                var simpleClass = filedInfo.GetValue(null) as BaseEntity;

                builder.Entity(simpleClass.GetType()).HasData(simpleClass);
            }
        }

        base.OnModelCreating(builder);
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

        // ignore events if no dispatcher provided
        if (_dispatcher == null) return result;

        // dispatch events only if save was successful
        var entitiesWithEvents = ChangeTracker.Entries<EntityBase>()
            .Select(e => e.Entity)
            .Where(e => e.DomainEvents.Any())
            .ToArray();

        await _dispatcher.DispatchAndClearEvents(entitiesWithEvents);

        return result;
    }

    public override int SaveChanges() =>
          SaveChangesAsync().GetAwaiter().GetResult();

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
    public virtual DbSet<F_Form> F_Forms { get; set; }
    public virtual DbSet<F_Condition> F_Conditions { get; set; }
    public virtual DbSet<F_Case> F_Cases { get; set; }
    public virtual DbSet<F_WorkItem> F_WorkItems { get; set; }
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