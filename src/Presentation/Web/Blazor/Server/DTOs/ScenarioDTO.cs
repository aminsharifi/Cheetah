namespace Cheetah.Presentation.Web.Blazor.Server.DTOs;

public class ScenarioDTO
{
    #region Simple
    public Int64? SortIndex { get; set; }
    public String Name { get; set; }
    public String? DisplayName { get; set; }
    public String? Description { get; set; }
    public Guid? GuidRecord { get; set; }
    public Boolean EnableRecord { get; set; }
    public Int64? ERPCode { get; set; }
    public DateTimeOffset? Created { get; set; }
    public string? CreatedBy { get; set; }
    public DateTimeOffset? LastModified { get; set; }
    public string? LastModifiedBy { get; set; }
    #endregion

    public HashSet<TaskDTO>? Tasks { get; set; } = default;
    public HashSet<ProcessScenarioDTO>? ProcessScenarios { get; set; } = default;
    public HashSet<ScenarioConditionDTO>? ScenarioConditions { get; private set; } = default;
}
public class TaskDTO
{
    #region Simple
    public Int64? SortIndex { get; set; }
    public String Name { get; set; }
    public String? DisplayName { get; set; }
    public String? Description { get; set; }
    public Guid? GuidRecord { get; set; }
    public Boolean EnableRecord { get; set; } = true;
    public Int64? ERPCode { get; set; }
    public DateTimeOffset? Created { get; set; }
    public string? CreatedBy { get; set; }
    public DateTimeOffset? LastModified { get; set; }
    public string? LastModifiedBy { get; set; }
    #endregion

    #region Entity

    public long? ScenarioId { get; set; }
    public virtual ScenarioDTO? Scenario { get; set; }

    #endregion

    #region Collections
    public HashSet<TaskFlowDTO>? TaskFlows { get; set; } = default;
    public HashSet<TaskConditionDTO>? TaskConditions { get; set; } = default;
    public HashSet<FlowTaskDTO>? FlowTasks { get; set; } = default;
    #endregion

}
public class TaskFlowDTO
{
    public virtual TaskDTO? Task { get; set; }
    public virtual FlowDTO? Flow { get; set; }

    #region Simple
    public Int64? SortIndex { get; set; }
    public String Name { get; set; }
    public String? DisplayName { get; set; }
    public String? Description { get; set; }
    public Guid? GuidRecord { get; set; } = Guid.NewGuid();
    public Boolean EnableRecord { get; set; } = true;
    public Int64? ERPCode { get; set; }
    public DateTimeOffset? Created { get; set; } = DateTimeOffset.Now;
    public string? CreatedBy { get; set; }
    public DateTimeOffset? LastModified { get; set; }
    public string? LastModifiedBy { get; set; }
    #endregion

    #region SimpleLink
    public Int64? FirstId { get; set; }
    public Int64? SecondId { get; set; }
    public Int64? ThirdId { get; set; }
    public Int64? FourthId { get; set; }
    public Int64? FifthId { get; set; }
    #endregion
}
public class FlowDTO
{
    #region Simple
    public Int64? SortIndex { get; set; }
    public String Name { get; set; }
    public String? DisplayName { get; set; }
    public String? Description { get; set; }
    public Guid? GuidRecord { get; set; } = Guid.NewGuid();
    public Boolean EnableRecord { get; set; } = true;
    public Int64? ERPCode { get; set; }
    public DateTimeOffset? Created { get; set; } = DateTimeOffset.Now;
    public string? CreatedBy { get; set; }
    public DateTimeOffset? LastModified { get; set; }
    public string? LastModifiedBy { get; set; }
    #endregion


    #region Entities    
    public long? CaseStateId { get; set; }
    #endregion

    #region Collection
    public HashSet<FlowConditionDTO>? FlowConditions { get; set; } = default;
    public HashSet<TaskFlowDTO>? TaskFlows { get; set; } = default;
    public HashSet<FlowTaskDTO>? FlowTasks { get; set; } = default;

    #endregion
}
public class ProcessScenarioDTO
{
    public ProcessDTO? Process { get; private set; }

    public ScenarioDTO? Scenario { get; private set; }

    #region Simple
    public Int64? SortIndex { get; set; }
    public String Name { get; set; }
    public String? DisplayName { get; set; }
    public String? Description { get; set; }
    public Guid? GuidRecord { get; set; } = Guid.NewGuid();
    public Boolean EnableRecord { get; set; } = true;
    public Int64? ERPCode { get; set; }
    public DateTimeOffset? Created { get; set; } = DateTimeOffset.Now;
    public string? CreatedBy { get; set; }
    public DateTimeOffset? LastModified { get; set; }
    public string? LastModifiedBy { get; set; }
    #endregion

    #region SimpleLink
    public Int64? FirstId { get; set; }
    public Int64? SecondId { get; set; }
    public Int64? ThirdId { get; set; }
    public Int64? FourthId { get; set; }
    public Int64? FifthId { get; set; }
    #endregion
}
public class ScenarioConditionDTO
{
    public ScenarioDTO? Scenario { get; set; }

    #region Simple
    public Int64? SortIndex { get; set; }
    public String Name { get; set; }
    public String? DisplayName { get; set; }
    public String? Description { get; set; }
    public Guid? GuidRecord { get; set; } = Guid.NewGuid();
    public Boolean EnableRecord { get; set; } = true;
    public Int64? ERPCode { get; set; }
    public DateTimeOffset? Created { get; set; } = DateTimeOffset.Now;
    public string? CreatedBy { get; set; }
    public DateTimeOffset? LastModified { get; set; }
    public string? LastModifiedBy { get; set; }
    #endregion

    #region SimpleLink
    public Int64? FirstId { get; set; }
    public Int64? SecondId { get; set; }
    public Int64? ThirdId { get; set; }
    public Int64? FourthId { get; set; }
    public Int64? FifthId { get; set; }
    #endregion
}
public class TaskConditionDTO
{
    public TaskDTO? Task { get; set; }

    #region Simple
    public Int64? SortIndex { get; set; }
    public String Name { get; set; }
    public String? DisplayName { get; set; }
    public String? Description { get; set; }
    public Guid? GuidRecord { get; set; } = Guid.NewGuid();
    public Boolean EnableRecord { get; set; } = true;
    public Int64? ERPCode { get; set; }
    public DateTimeOffset? Created { get; set; } = DateTimeOffset.Now;
    public string? CreatedBy { get; set; }
    public DateTimeOffset? LastModified { get; set; }
    public string? LastModifiedBy { get; set; }
    #endregion

    #region SimpleLink
    public Int64? FirstId { get; set; }
    public Int64? SecondId { get; set; }
    public Int64? ThirdId { get; set; }
    public Int64? FourthId { get; set; }
    public Int64? FifthId { get; set; }
    #endregion
}
public class FlowTaskDTO
{
    public FlowDTO? Flow { get; set; }
    public TaskDTO? Task { get; set; }

    #region Simple
    public Int64? SortIndex { get; set; }
    public String Name { get; set; }
    public String? DisplayName { get; set; }
    public String? Description { get; set; }
    public Guid? GuidRecord { get; set; } = Guid.NewGuid();
    public Boolean EnableRecord { get; set; } = true;
    public Int64? ERPCode { get; set; }
    public DateTimeOffset? Created { get; set; } = DateTimeOffset.Now;
    public string? CreatedBy { get; set; }
    public DateTimeOffset? LastModified { get; set; }
    public string? LastModifiedBy { get; set; }
    #endregion

    #region SimpleLink
    public Int64? FirstId { get; set; }
    public Int64? SecondId { get; set; }
    public Int64? ThirdId { get; set; }
    public Int64? FourthId { get; set; }
    public Int64? FifthId { get; set; }
    #endregion
}
public class FlowConditionDTO
{
    public FlowDTO? Flow { get; set; }

    #region Simple
    public Int64? SortIndex { get; set; }
    public String Name { get; set; }
    public String? DisplayName { get; set; }
    public String? Description { get; set; }
    public Guid? GuidRecord { get; set; } = Guid.NewGuid();
    public Boolean EnableRecord { get; set; } = true;
    public Int64? ERPCode { get; set; }
    public DateTimeOffset? Created { get; set; } = DateTimeOffset.Now;
    public string? CreatedBy { get; set; }
    public DateTimeOffset? LastModified { get; set; }
    public string? LastModifiedBy { get; set; }
    #endregion

    #region SimpleLink
    public Int64? FirstId { get; set; }
    public Int64? SecondId { get; set; }
    public Int64? ThirdId { get; set; }
    public Int64? FourthId { get; set; }
    public Int64? FifthId { get; set; }
    #endregion
}
public class ProcessDTO
{
    #region Simple
    public Int64? SortIndex { get; set; }
    public String Name { get; set; }
    public String? DisplayName { get; set; }
    public String? Description { get; set; }
    public Guid? GuidRecord { get; set; } = Guid.NewGuid();
    public Boolean EnableRecord { get; set; } = true;
    public Int64? ERPCode { get; set; }
    public DateTimeOffset? Created { get; set; } = DateTimeOffset.Now;
    public string? CreatedBy { get; set; }
    public DateTimeOffset? LastModified { get; set; }
    public string? LastModifiedBy { get; set; }
    #endregion

    #region Simple Prob

    #region Others
    public bool? ShowSupport { get; private set; } = true;
    public bool? ERP { get; private set; } = true;
    public bool? RemoveRequestorApproval { get; private set; } = true;

    #endregion

    #endregion

    #region Relations
    public HashSet<ProcessScenarioDTO>? ProcessScenarios { get; private set; } = default;
    #endregion
}