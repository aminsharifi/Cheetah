namespace Cheetah.Domain.Entities.Links;

public partial class L_UserCondition : SimpleLinkClass
{
    public L_UserCondition()
    {
        
    }
    public L_UserCondition(Int64 id, String? name, String? displayName,
     Int64? sortIndex, Int64? eRPCode, Int64? userId, Int64? conditionId) :
        base(id, name, displayName, sortIndex, eRPCode, userId, conditionId)
    {
    }
    public virtual D_User? User { get; private set; }

    public L_UserCondition ShallowCopy()
    {
        return (L_UserCondition)MemberwiseClone();
    }
}