using Cheetah.Core.Common;
using Cheetah.Core.Entities.Facts;

namespace Cheetah.Core.Aggregates.CaseAggregate.Links;

public partial class L_CaseCondition : BaseLink
{
    public L_CaseCondition()
    {

    }

    public virtual F_Case Case { get; private set; }



    public L_CaseCondition ShallowCopy()
    {
        return (L_CaseCondition)MemberwiseClone();
    }
}