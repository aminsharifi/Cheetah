namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_Entity : BaseEntity
{
    public bool? Display { get; set; } = false;
    public bool? Sync { get; set; } = false;
}
public partial class D_Entity
{
    #region Values

    public static readonly D_Entity D_TagType =
        new()
        {
            Id = 101,
            ERPCode = 101,
            SortIndex = 101,
            Name = nameof(D_TagType),
            DisplayName = new StringBuilder().Append("نوع تگ‌ها")
                            .Append($"({TableType.Dimentions})").ToString(),
            Display = false
        };

    public static readonly D_Entity D_Operand =
        new()
        {
            Id = 102,
            ERPCode = 102,
            SortIndex = 102,
            Name = nameof(D_Operand),
            DisplayName = new StringBuilder().Append("عملگرها")
                .Append($"({TableType.Dimentions})").ToString(),
            Display = false
        };

    public static readonly D_Entity D_Tag =
        new()
        {
            Id = 103,
            ERPCode = 103,
            SortIndex = 103,
            Name = nameof(D_Tag),
            DisplayName = new StringBuilder().Append("تگ‌ها")
            .Append($"({TableType.Dimentions})").ToString(),
            Display = true
        };

    public static readonly D_Entity D_CaseState =
        new()
        {
            Id = 104,
            ERPCode = 104,
            SortIndex = 104,
            Name = nameof(D_CaseState),
            DisplayName = new StringBuilder().Append("وضعیت فرآیندها")
                .Append($"({TableType.Dimentions})").ToString(),
            Display = false
        };

    public static readonly D_Entity D_Process =
        new()
        {
            Id = 105,
            ERPCode = 105,
            SortIndex = 105,
            Name = nameof(D_Process),
            DisplayName = new StringBuilder().Append("فرآیند‌ها")
                .Append($"({TableType.Dimentions})").ToString(),
            Display = true
        };

    public static readonly D_Entity D_User =
        new()
        {
            Id = 106,
            ERPCode = 106,
            SortIndex = 106,
            Name = nameof(D_User),
            DisplayName = new StringBuilder().Append("کاربران")
                        .Append($"({TableType.Dimentions})").ToString(),
            Display = true
        };

    public static readonly D_Entity D_UserInformation =
        new()
        {
            Id = 107,
            ERPCode = 107,
            SortIndex = 107,
            Name = nameof(D_UserInformation),
            DisplayName = new StringBuilder().Append("اطلاعات کاربرها")
                        .Append($"({TableType.Facts})").ToString(),
            Display = false
        };

    public static readonly D_Entity F_WorkItem =
        new()
        {
            Id = 108,
            ERPCode = 108,
            SortIndex = 108,
            Name = nameof(F_WorkItem),
            DisplayName = new StringBuilder().Append("تمام تاییدها")
                .Append($"({TableType.Facts})").ToString(),
            Display = false
        };

    public static readonly D_Entity F_Attachment =
        new()
        {
            Id = 109,
            ERPCode = 109,
            SortIndex = 109,
            Name = nameof(F_Attachment),
            DisplayName = new StringBuilder().Append("ضمیمه‌ها")
                        .Append($"({TableType.Facts})").ToString(),
            Display = false
        };

    public static readonly D_Entity F_Task =
        new()
        {
            Id = 110,
            ERPCode = 110,
            SortIndex = 110,
            Name = nameof(F_Task),
            DisplayName = new StringBuilder().Append("لیست تخصیص‌ها")
                        .Append($"({TableType.Facts})").ToString(),
            Display = false
        };

    public static readonly D_Entity F_Condition =
        new()
        {
            Id = 111,
            ERPCode = 111,
            SortIndex = 111,
            Name = nameof(F_Condition),
            DisplayName = new StringBuilder().Append("لیست شرط‌ها")
                .Append($"({TableType.Facts})").ToString(),
            Display = true
        };

    public static readonly D_Entity F_Case =
        new()
        {
            Id = 112,
            ERPCode = 112,
            SortIndex = 112,
            Name = nameof(F_Case),
            DisplayName = new StringBuilder().Append("اطلاعات درخواست‌ها")
                .Append($"({TableType.Facts})").ToString(),
            Display = false
        };

    public static readonly D_Entity F_Scenario =
        new()
        {
            Id = 113,
            ERPCode = 113,
            SortIndex = 113,
            Name = nameof(F_Scenario),
            DisplayName = new StringBuilder().Append("سناریوها")
                 .Append($"({TableType.Facts})").ToString(),
            Display = true
        };

    public static readonly D_Entity L_ProcessScenario =
        new()
        {
            Id = 114,
            ERPCode = 114,
            SortIndex = 114,
            Name = nameof(L_ProcessScenario),
            DisplayName = new StringBuilder().Append("فرآیند-سناریو")
            .Append($"({TableType.Links})").ToString(),
            Display = false
        };

    #endregion
}