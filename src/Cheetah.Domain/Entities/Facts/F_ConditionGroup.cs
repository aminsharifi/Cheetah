namespace Cheetah.Domain.Entities.Facts;
public partial class F_ConditionGroup : BaseEntity
{
    #region Collections
    public virtual ICollection<L_ConditionGroupCondition>? L_ConditionGroupConditions { get; set; } = new HashSet<L_ConditionGroupCondition>();
    #endregion

    public F_ConditionGroup ShallowCopy()
    {
        return (F_ConditionGroup)MemberwiseClone();
    }
    public override void SetName()
    {
      
    }
}
