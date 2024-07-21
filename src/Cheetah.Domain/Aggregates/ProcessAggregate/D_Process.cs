using Cheetah.Domain.Common;
using Cheetah.Domain.Entities.Links;
namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_Process : BaseEntity, IAggregateRoot
{
    public D_Process()
    {
        
    }


    #region Simple Prob

    #region Others
    public bool? ShowSupport { get; private set; } = true;
    public bool? ERP { get; private set; } = true;
    public bool? RemoveRequestorApproval { get; private set; } = true;

    #endregion

    #endregion

    #region Relations
    public virtual ICollection<L_ProcessScenario>? ProcessScenarios { get; private set; } = new HashSet<L_ProcessScenario>();
    #endregion
}