using Cheetah.Core.Aggregates.UserAggregate.Dimentions;
using Cheetah.Core.Common;

namespace Cheetah.Core.Aggregates.UserAggregate.Links;

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