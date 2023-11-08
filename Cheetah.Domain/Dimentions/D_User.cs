namespace Cheetah.Domain.Dimentions;

[Table(nameof(D_User), Schema = nameof(TableType.Dimentions))]
public partial class D_User : BaseClass<D_User>
{
    public D_User()
    {

    }

    #region Common Prop
    #endregion

    #region Simple Prob
    [StringLength(25)]
    [Column(Order = 102)]
    public string? Domain { get; set; }
    [Column(Order = 103)]
    public bool? EnabledForAssignation { get; set; }
    [Column(Order = 104)]
    public bool? DelegateEnabled { get; set; }
    [Column(Order = 105)]
    public bool? CreatedCasesSkipAssigRules { get; set; }
    [StringLength(10)]
    [Column(Order = 106)]
    public string? IDPersonel { get; set; }
    [StringLength(20)]
    [Column(Order = 107)]
    public string? LDAPDescription { get; set; }

    #endregion

    #region Relations

    #region Entity   

    #region S_User

    [Column(Order = 109)]
    public long? DelegateId { get; set; }
    [ForeignKey(nameof(DelegateId))]
    public virtual D_User? Delegate { get; set; }

    [Column(Order = 110)]
    public long? UserInformationId { get; set; }
    public virtual D_UserInformation? UserInformation { get; set; }
    #endregion

    #endregion

    #region Collection
    public virtual ICollection<F_Condition>? Conditions { get; set; } = new HashSet<F_Condition>();

    [Description("موقعیت")]
    public virtual ICollection<L_UserLocation>? UserLocations { get; set; } = new HashSet<L_UserLocation>();

    public virtual ICollection<L_UserPosition>? UserPositions { get; set; } = new HashSet<L_UserPosition>();

    #endregion

    #endregion

    public D_User ShallowCopy()
    {
        return (D_User)this.MemberwiseClone();
    }
}