namespace Cheetah.Application.Business.Entity;
public class CreateRequest_Input
{
    public GRPC_BaseClass? Case { get; set; }
    public GRPC_BaseClassWithName? Creator { get; set; }
    public GRPC_BaseClassWithName? Requestor { get; set; }
    public GRPC_BaseClassWithName? Process { get; set; }
    public List<GRPC_Condition>? Conditions { get; set; }
    public GRPC_WorkItem? WorkItem { get; set; }
}
public class CreateRequest_Output
{
    public GRPC_Case? Case { get; set; }
    public GRPC_BaseClassWithName? OutputState { get; set; }
}
public class GetAllByName_Input
{
    public GRPC_BaseClassWithName? TableInput { get; set; }
}
public class GetAllByName_Output
{
    public GRPC_BaseClassWithName? TableInput { get; set; }
    public List<GRPC_BaseClassWithName>? TableOutput { get; set; }
    public GRPC_BaseClassWithName? OutputState { get; set; }
}
public class GetCase_Input
{
    public GRPC_BaseClass? Case { get; set; }
    public GRPC_BaseClassWithName? CaseState { get; set; }
    public GRPC_BaseClassWithName? Process { get; set; }
}
public class GetCase_Output
{
    public GRPC_Case? Case { get; set; }
    public GRPC_BaseClassWithName? OutputState { get; set; }
}
public class PerformRequest_Input
{
    public GRPC_WorkItem? WorkItem { get; set; }
    public bool? Rebase { get; set; }
}
public class PerformRequest_Output
{
    public GRPC_Case? Case { get; set; }
    public GRPC_BaseClassWithName? OutputState { get; set; }
}
public class Cartable_Input
{
    public Int64? PageNumber { get; set; }
    public Int64? PageSize { get; set; }
    public Int64? TotalItems { get; set; }
    public GRPC_BaseClassWithName? Assignee { get; set; }
    public GRPC_BaseClassWithName? CaseState { get; set; }
    public GRPC_BaseClassWithName? Process { get; set; }
    public GRPC_BaseClass? Case { get; set; }
    public GRPC_BaseClass? WorkItem { get; set; }
}
public class Cartable_Output
{
    public Int64? PageNumber { get; set; }
    public Int64? PageSize { get; set; }
    public Int64? TotalItems { get; set; }
    public List<GRPC_Case>? Cases { get; set; }
    public GRPC_BaseClassWithName? OutputState { get; set; }
}
public class SetCaseTaskUser_Input
{
    public GRPC_BaseClass? Case { get; set; }
    public GRPC_BaseClassWithName? Task { get; set; }
    public GRPC_BaseClassWithName? User { get; set; }
}
public class SetCaseTaskUser_Output
{
    public GRPC_BaseClass? Case { get; set; }
    public GRPC_BaseClassWithName? Task { get; set; }
    public GRPC_BaseClassWithName? User { get; set; }
    public GRPC_BaseClassWithName? OutputState { get; set; }
}
public class SyncEntity_Input
{
    public GRPC_BaseClassWithName? Base { get; set; }
    public List<GRPC_BaseClassWithNameAndDate>? Records { get; set; }
    public long? Crud { get; set; }
}
public class SyncEntity_Output
{
    public GRPC_BaseClassWithName? Result { get; set; }
    public GRPC_BaseClassWithName? OutputState { get; set; }
}
public class SyncLink_Input
{
    public GRPC_BaseClassWithName? Base { get; set; }
    public List<LinkEntity>? Records { get; set; }
    public long? Crud { get; set; }
}
public class SyncLink_Output
{
    public GRPC_BaseClassWithName? Result { get; set; }
    public GRPC_BaseClassWithName? OutputState { get; set; }
}
public class SyncCondition_Input
{
    public GRPC_BaseClassWithName? Base { get; set; }
    public List<GRPC_Condition>? Records { get; set; }
    public long? Crud { get; set; }
}
public class SyncCondition_Output
{
    public GRPC_BaseClassWithName? Result { get; set; }
    public GRPC_BaseClassWithName? OutputState { get; set; }
}
public class LinkEntity
{
    public GRPC_BaseClass? First { get; set; }
    public GRPC_BaseClass? Second { get; set; }
    public long? ERPCode { get; set; }
    public Boolean? EnableRecord { get; set; }
}
public class GRPC_BaseClass
{
    public Int64? Id { get; set; }
    public Int64? ERPCode { get; set; }
    public Int64? SortIndex { get; set; }
    public Boolean? EnableRecord { get; set; }
}
public class GRPC_BaseClassWithName : GRPC_BaseClass
{
    public String? Name { get; set; }
    public String? DisplayName { get; set; }
}
public class GRPC_BaseClassWithDate : GRPC_BaseClass
{
    public DateTimeOffset? Created { get; set; }
    public DateTimeOffset? LastModified { get; set; }
}
public class GRPC_BaseClassWithNameAndDate : GRPC_BaseClassWithDate
{
    public String? Name { get; set; }
    public String? DisplayName { get; set; }
}
public class GRPC_Task
{
    public GRPC_BaseClassWithName? Base { get; set; }
    public List<GRPC_Condition?>? Performers { get; set; }
    public List<GRPC_Condition?>? ValidUserActions { get; set; }
    public List<GRPC_WorkItem>? WorkItems { get; set; }
}
public class GRPC_WorkItem
{
    public GRPC_BaseClassWithDate? Base { get; set; }
    public GRPC_BaseClassWithName? User { get; set; }
    public GRPC_BaseClassWithName? WorkItemState { get; set; }
    public List<GRPC_Condition?>? OccurredUserActions { get; set; }
}
public class GRPC_Condition
{
    public GRPC_BaseClassWithName? Base { get; set; }
    public GRPC_BaseClassWithName? Tag { get; set; }
    public GRPC_BaseClassWithName? Operand { get; set; }
    public string? Value { get; set; }
}
public class GRPC_Case
{
    public GRPC_BaseClassWithDate? Base { get; set; }
    public long? ProcessId { get; set; }
    public long? CreatorId { get; set; }
    public long? RequestorId { get; set; }
    public List<GRPC_Task>? Tasks { get; set; }
    public GRPC_BaseClassWithName? CaseState { get; set; }
}