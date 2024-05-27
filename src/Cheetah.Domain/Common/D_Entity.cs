namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_Entity : BaseEntity
{
    public D_Entity()
    {
    }
    public D_Entity(Int64 id, String name, String displayName, Int64 sortIndex,
      Int64 eRPCode)
      : base(id, name, displayName, sortIndex, eRPCode)
    {
    }
    public D_Entity(Int64 id, String name, String displayName, Int64 sortIndex,
        Int64 eRPCode, Boolean display)
        : base(id, name, displayName, sortIndex, eRPCode)
    {
        Display = display;
    }

    public bool? Display { get; private set; } = false;
    public bool? Sync { get; private set; } = false;
}
public partial class D_Entity
{
    #region Values

    public static readonly D_Entity D_TagType = new(id: 101, name: nameof(D_TagType),
        displayName: new StringBuilder().Append("نوع تگ‌ها").Append($"({TableType.Dimentions})").ToString()
        , sortIndex: 101, eRPCode: 101, display: false);

    public static readonly D_Entity D_Operand = new(id: 102, name: nameof(D_Operand),
        displayName: new StringBuilder().Append("عملگرها").Append($"({TableType.Dimentions})").ToString()
        , sortIndex: 102, eRPCode: 102, display: false);

    public static readonly D_Entity D_Tag = new(id: 103, name: nameof(D_Tag),
        displayName: new StringBuilder().Append("تگ‌ها").Append($"({TableType.Dimentions})").ToString()
        , sortIndex: 103, eRPCode: 103, display: true);

    public static readonly D_Entity D_CaseState = new(id: 104, name: nameof(D_CaseState),
        displayName: new StringBuilder().Append("وضعیت فرآیندها").Append($"({TableType.Dimentions})").ToString()
        , sortIndex: 104, eRPCode: 104, display: false);

    public static readonly D_Entity D_Process = new(id: 105, name: nameof(D_Process),
        displayName: new StringBuilder().Append("فرآیند‌ها").Append($"({TableType.Dimentions})").ToString()
        , sortIndex: 105, eRPCode: 105, display: true);

    public static readonly D_Entity D_User = new(id: 106, name: nameof(D_User),
        displayName: new StringBuilder().Append("کاربران").Append($"({TableType.Dimentions})").ToString()
        , sortIndex: 106, eRPCode: 106, display: true);

    public static readonly D_Entity D_UserInformation = new(id: 107, name: nameof(D_UserInformation),
        displayName: new StringBuilder().Append("اطلاعات کاربرها").Append($"({TableType.Facts})").ToString()
        , sortIndex: 107, eRPCode: 107, display: true);

    public static readonly D_Entity F_WorkItem = new(id: 108, name: nameof(F_WorkItem),
        displayName: new StringBuilder().Append("تمام تاییدها").Append($"({TableType.Facts})").ToString()
        , sortIndex: 108, eRPCode: 108, display: true);

    public static readonly D_Entity F_Attachment = new(id: 109, name: nameof(F_Attachment),
        displayName: new StringBuilder().Append("ضمیمه‌ها").Append($"({TableType.Facts})").ToString()
        , sortIndex: 109, eRPCode: 109, display: false);

    public static readonly D_Entity F_Task = new(id: 110, name: nameof(F_Task),
        displayName: new StringBuilder().Append("لیست تخصیص‌ها").Append($"({TableType.Facts})").ToString()
        , sortIndex: 110, eRPCode: 110, display: false);

    public static readonly D_Entity F_Condition = new(id: 111, name: nameof(F_Condition),
        displayName: new StringBuilder().Append("لیست شرط‌ها").Append($"({TableType.Facts})").ToString()
        , sortIndex: 111, eRPCode: 111, display: true);

    public static readonly D_Entity F_Case = new(id: 112, name: nameof(F_Case),
        displayName: new StringBuilder().Append("اطلاعات درخواست‌ها").Append($"({TableType.Facts})").ToString()
        , sortIndex: 112, eRPCode: 112, display: false);

    public static readonly D_Entity F_Scenario = new(id: 113, name: nameof(F_Scenario),
        displayName: new StringBuilder().Append("سناریوها").Append($"({TableType.Facts})").ToString()
        , sortIndex: 113, eRPCode: 113, display: true);

    public static readonly D_Entity L_ProcessScenario = new(id: 114, name: nameof(L_ProcessScenario),
        displayName: new StringBuilder().Append("سناریوها").Append($"({TableType.Links})").ToString()
        , sortIndex: 114, eRPCode: 114, display: false);

    #endregion
}