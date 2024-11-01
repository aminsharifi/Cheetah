namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.EntityManager.Queries;

public class UpdateUsersRequest
{
    public const string Route = "/EntityManager/Commands/UpdateUsers";
    public List<DUser> UserList { get; set; }
}
public class DUser
{
    public long Id { get; set; } // bigint
    public long? SortIndex { get; set; } // bigint
    public string Name { get; set; } // nvarchar(512)
    public string DisplayName { get; set; } // nvarchar(512)
    public string Description { get; set; } // nvarchar(512)
    public DateTimeOffset? Created { get; set; } // datetimeoffset(7)
    public DateTimeOffset? LastModified { get; set; } // datetimeoffset(7)
    public Guid? GuidRecord { get; set; } // uniqueidentifier
    public bool EnableRecord { get; set; } // bit
    public long? ERPCode { get; set; } // bigint
    public string LastModifiedBy { get; set; } // nvarchar(512)
    public string CreatedBy { get; set; } // nvarchar(512)
    public string Domain { get; set; } // nvarchar(25)
    public bool? EnabledForAssignation { get; set; } // bit
    public bool? DelegateEnabled { get; set; } // bit
    public bool? CreatedCasesSkipAssigRules { get; set; } // bit
    public string IDPersonel { get; set; } // nvarchar(10)
    public string LDAPDescription { get; set; } // nvarchar(20)
    public long? DelegateId { get; set; } // bigint
    public long? UserInformationId { get; set; } // bigint
    public long? ParentId { get; set; } // bigint
    public long? ManagerId { get; set; } // bigint
}