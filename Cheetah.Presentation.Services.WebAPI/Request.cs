namespace Cheetah.Presentation.Services.WebAPI;

public class SetCaseEndorsementUser_Input
{
    public GRPC_BaseClass? Case { get; set; }
    public GRPC_BaseClassWithName? Endorsement { get; set; }
    public GRPC_BaseClassWithName? User { get; set; }
}

public class SetCaseEndorsementUser_Output
{
    public GRPC_BaseClass? Case { get; set; }
    public GRPC_BaseClassWithName? Endorsement { get; set; }
    public GRPC_BaseClassWithName? User { get; set; }
    public GRPC_BaseClassWithName? OutputState { get; set; }
}

public class CreateRequest_Input
{
    public GRPC_BaseClass? Case { get; set; }
    public GRPC_BaseClassWithName? Creator { get; set; }
    public GRPC_BaseClassWithName? Requestor { get; set; }
    public GRPC_BaseClassWithName? Process { get; set; }
    public List<Condition>? Conditions { get; set; }
}

public class CreateRequest_Output
{
    public GRPC_BaseClassWithDate? Case { get; set; }
    public GRPC_BaseClassWithName? OutputState { get; set; }
}

public class PerformRequest_Input
{
    public GRPC_BaseClass? WorkItem { get; set; }
    public List<Condition>? Conditions { get; set; }
    public bool? Rebase { get; set; }
}

public class PerformRequest_Output
{
    public GRPC_BaseClass? Case { get; set; }
    public GRPC_BaseClassWithName? Process { get; set; }
    public GRPC_BaseClassWithName? CaseState { get; set; }
    public GRPC_BaseClassWithName? OutputState { get; set; }
}

public class GetCase_Input
{
    public GRPC_BaseClass? Case { get; set; }
    public GRPC_BaseClassWithName? CaseState { get; set; }
    public GRPC_BaseClassWithName? Process { get; set; }
}

public class Condition
{
    public GRPC_BaseClassWithName? Tag { get; set; }
    public GRPC_BaseClassWithName? Operand { get; set; }
    public String? Value { get; set; }
    public GRPC_BaseClassWithName? User { get; set; }
    public GRPC_BaseClassWithName? Base { get; set; }
}

public class GetCase_Output
{
    public GRPC_BaseClass? Case { get; set; }
    public GRPC_BaseClassWithName? CaseState { get; set; }
    public GRPC_BaseClassWithName? Process { get; set; }
    public List<GRPC_Endorsement>? Endorsements { get; set; }
    public GRPC_BaseClassWithName? OutputState { get; set; }
}

public class GRPC_Endorsement
{
    public GRPC_BaseClassWithName? Endorsement { get; set; }
    public List<GRPC_WorkItem>? WorkItems { get; set; }
}

public class GRPC_WorkItem
{
    public GRPC_BaseClassWithDate? WorkItem { get; set; }
    public GRPC_BaseClassWithName? User { get; set; }
    public GRPC_BaseClassWithName? Tag { get; set; }
    public GRPC_BaseClassWithName? WorkItemState { get; set; }
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
    public List<RecordCartable>? RecordCartables { get; set; }
    public GRPC_BaseClassWithName? OutputState { get; set; }
}

public class RecordCartable
{
    public GRPC_BaseClassWithName? Process { get; set; }
    public GRPC_BaseClassWithDate? Case { get; set; }
    public GRPC_BaseClassWithName? CaseState { get; set; }
    public GRPC_BaseClassWithName? Requestor { get; set; }
    public GRPC_BaseClassWithName? Endorsement { get; set; }
    public GRPC_BaseClassWithDate? WorkItem { get; set; }
    public GRPC_BaseClassWithName? Assignee { get; set; }
    public GRPC_BaseClassWithName? Tag { get; set; }
    public List<GRPC_BaseClassWithName>? ValidUserActions { get; set; }
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

public class GRPC_BaseClass
{
    public Int64? Id { get; set; }
    public Int64? ERPCode { get; set; }
    public Int64? SortIndex { get; set; }
}

public class GRPC_BaseClassWithName
{
    public Int64? Id { get; set; }
    public Int64? ERPCode { get; set; }
    public Int64? SortIndex { get; set; }
    public String? Name { get; set; }
    public String? DisplayName { get; set; }
}

public class GRPC_BaseClassWithDate
{
    public Int64? Id { get; set; }
    public Int64? ERPCode { get; set; }
    public Int64? SortIndex { get; set; }
    public DateTimeOffset? CreateTimeRecord { get; set; }
    public DateTimeOffset? LastUpdatedRecord { get; set; }
}

public class GRPC_BaseClassWithNameAndDate
{
    public Int64? Id { get; set; }
    public Int64? ERPCode { get; set; }
    public Int64? SortIndex { get; set; }
    public String? Name { get; set; }
    public String? DisplayName { get; set; }
    public DateTimeOffset? CreateTimeRecord { get; set; }
    public DateTimeOffset? LastUpdatedRecord { get; set; }
}