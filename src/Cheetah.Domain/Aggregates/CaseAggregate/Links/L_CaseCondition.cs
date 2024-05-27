namespace Cheetah.Domain.Entities.Links;

public partial class L_CaseCondition : SimpleLinkClass
{
    public L_CaseCondition()
    {
        
    }
    public L_CaseCondition(Int64? conditionId) : base(secondId: conditionId)
    {

    }
    public virtual F_Case Case { get; set; }

    public L_CaseCondition ShallowCopy()
    {
        return (L_CaseCondition)MemberwiseClone();
    }
}