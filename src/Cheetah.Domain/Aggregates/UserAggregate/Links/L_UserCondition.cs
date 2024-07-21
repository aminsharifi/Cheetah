using Cheetah.Domain.Common;
using Cheetah.Domain.Entities.Dimentions;

namespace Cheetah.Domain.Aggregates.UserAggregate.Links;

public partial class L_UserCondition : BaseLink
{
    public L_UserCondition()
    {

    }
    public virtual D_User? User { get; private set; }

    public L_UserCondition ShallowCopy()
    {
        return (L_UserCondition)MemberwiseClone();
    }
}