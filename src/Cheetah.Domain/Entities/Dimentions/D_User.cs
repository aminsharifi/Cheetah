namespace Cheetah.Domain.Entities.Dimentions;
public class D_User : BaseClass<D_User>
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
    [ForeignKey(nameof(DelegateId))]
    public virtual D_User? Delegate { get; set; }

    public long? UserInformationId { get; set; }
    [ForeignKey(nameof(UserInformationId))]
    public virtual D_UserInformation? UserInformation { get; set; }
    #endregion

    #endregion

    #region Collection
    public virtual ICollection<F_Condition>? Conditions { get; set; } = new HashSet<F_Condition>();
    public virtual ICollection<L_UserLocation>? UserLocations { get; set; } = new HashSet<L_UserLocation>();
    public virtual ICollection<L_UserPosition>? UserPositions { get; set; } = new HashSet<L_UserPosition>();

    #endregion

    #endregion

    public D_User ShallowCopy()
    {
        return (D_User)MemberwiseClone();
    }

    #region Values

    public static readonly D_User m_sharifi =
        new D_User
        {
            Id = 1,
            ERPCode = 1,
            SortIndex = 1,
            Name = nameof(m_sharifi).Replace('_', '.'),
            DisplayName = "محمد شریفی"
        };

    public static readonly D_User a_sharifi =
        new D_User
        {
            Id = 2,
            ERPCode = 2,
            SortIndex = 2,
            Name = nameof(a_sharifi).Replace('_', '.'),
            DisplayName = "امین شریفی"
        };

    #endregion
}