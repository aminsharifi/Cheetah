namespace Cheetah.Domain.Entities.Dimentions;
public partial class D_User : BaseEntity<D_User>,IAggregateRoot
{

    #region Common Prop
    #endregion

    #region Simple Prob    
    public string? Domain { get; set; }
    public bool? EnabledForAssignation { get; set; }
    public bool? DelegateEnabled { get; set; }
    public bool? CreatedCasesSkipAssigRules { get; set; }
    public string? IDPersonel { get; set; }
    public string? LDAPDescription { get; set; }

    #endregion

    #region Relations

    #region Entity   

    #region S_User
    public long? DelegateId { get; set; }
    public virtual D_User? Delegate { get; set; }

    public long? UserInformationId { get; set; }
    public virtual D_UserInformation? UserInformation { get; set; }
    #endregion

    #endregion

    #region Collection
    public virtual ICollection<L_UserCondition>? UserConditions { get; set; } = new HashSet<L_UserCondition>();    
    #endregion

    #endregion

    public D_User ShallowCopy()
    {
        return (D_User)MemberwiseClone();
    }

}