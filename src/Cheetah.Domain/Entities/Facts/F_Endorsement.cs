namespace Cheetah.Domain.Entities.Facts;
public partial class F_Endorsement : BaseEntity
{
    #region Entity

    public long? RoleId { get; set; }
    public virtual D_Role? Role { get; set; }

    public long? ScenarioId { get; set; }
    public virtual F_Scenario? Scenario { get; set; }

    public long? EndorsementItemId { get; set; }
    [ForeignKey(nameof(EndorsementItemId))]
    public virtual F_EndorsementItem? EndorsementItem { get; set; }

    #region For Variables
    public virtual long? ConditionId { get; set; }
    public virtual F_Condition? Condition { get; set; }
    #endregion

    #endregion

    #region Collections

    [InverseProperty(nameof(F_EndorsementItem.Endorsement))]
    public virtual ICollection<F_EndorsementItem>? EndorsementItems { get; set; } = new HashSet<F_EndorsementItem>();

    #endregion

    public override void SetName()
    {
        //DisplayName = Scenario?.DisplayName + "," + SortIndex + "," + Role?.DisplayName;
        //Name = Scenario?.Name + "," + SortIndex + "," + Role?.Name;
    }

    #region Functions
    public F_Endorsement ShallowCopy()
    {
        return (F_Endorsement)MemberwiseClone();
    }
    #region Getter
    public bool IsRequestor()
    {
        return RoleId == D_Role.Requestor.Id;
    }
    public bool IsRequestorManager()
    {
        return RoleId == D_Role.RequestorManager.Id;
    }
    #endregion

    #endregion
}