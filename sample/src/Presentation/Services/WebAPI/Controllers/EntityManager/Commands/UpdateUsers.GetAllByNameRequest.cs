using Cheetah.Core.Aggregates.UserAggregate.Dimentions;
using Novell.Directory.Ldap;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.EntityManager.Queries;

public class UpdateUsersRequest
{
    public const string Route = "/EntityManager/Commands/UpdateUsers";
    public List<string> UserList { get; set; }
}