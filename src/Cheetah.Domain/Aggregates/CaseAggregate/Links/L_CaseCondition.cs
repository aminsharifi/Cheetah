using Cheetah.Domain.Common;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Domain.Aggregates.CaseAggregate.Links;

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