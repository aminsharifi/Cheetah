namespace Cheetah.Domain.Entities.Dimentions;

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

    public static readonly D_Entity D_Location =
        new()
        {
            Id = 102,
            ERPCode = 102,
            SortIndex = 102,
            Name = nameof(D_Location),
            DisplayName = new StringBuilder().Append("موقعیت‌ها")
                            .Append($"({TableType.Dimentions})").ToString(),
            Display = false
        };

    public static readonly D_Entity D_Operand =
        new()
        {
            Id = 103,
            ERPCode = 103,
            SortIndex = 103,
            Name = nameof(D_Operand),
            DisplayName = new StringBuilder().Append("عملگرها")
                .Append($"({TableType.Dimentions})").ToString(),
            Display = false
        };

    public static readonly D_Entity D_Tag =
        new()
        {
            Id = 104,
            ERPCode = 104,
            SortIndex = 104,
            Name = nameof(D_Tag),
            DisplayName = new StringBuilder().Append("تگ‌ها")
            .Append($"({TableType.Dimentions})").ToString(),
            Display = true
        };

    public static readonly D_Entity D_Position =
        new()
        {
            Id = 105,
            ERPCode = 105,
            SortIndex = 105,
            Name = nameof(D_Position),
            DisplayName = new StringBuilder().Append("سمت‌ها")
            .Append($"({TableType.Dimentions})").ToString(),
            Display = false
        };

    public static readonly D_Entity D_CaseState =
        new()
        {
            Id = 106,
            ERPCode = 106,
            SortIndex = 106,
            Name = nameof(D_CaseState),
            DisplayName = new StringBuilder().Append("وضعیت فرآیندها")
                .Append($"({TableType.Dimentions})").ToString(),
            Display = false
        };

    public static readonly D_Entity D_Process =
        new()
        {
            Id = 107,
            ERPCode = 107,
            SortIndex = 107,
            Name = nameof(D_Process),
            DisplayName = new StringBuilder().Append("فرآیند‌ها")
                .Append($"({TableType.Dimentions})").ToString(),
            Display = true
        };

    public static readonly D_Entity D_Role =
        new()
        {
            Id = 108,
            ERPCode = 108,
            SortIndex = 108,
            Name = nameof(D_Role),
            DisplayName = new StringBuilder().Append("نقش‌ها")
                .Append($"({TableType.Dimentions})").ToString(),
            Display = true
        };

    public static readonly D_Entity D_User =
        new()
        {
            Id = 109,
            ERPCode = 109,
            SortIndex = 109,
            Name = nameof(D_User),
            DisplayName = new StringBuilder().Append("کاربران")
                        .Append($"({TableType.Dimentions})").ToString(),
            Display = true
        };

    public static readonly D_Entity D_UserInformation =
        new()
        {
            Id = 112,
            ERPCode = 112,
            SortIndex = 112,
            Name = nameof(D_UserInformation),
            DisplayName = new StringBuilder().Append("اطلاعات کاربرها")
                        .Append($"({TableType.Facts})").ToString(),
            Display = false
        };

    public static readonly D_Entity F_WorkItem =
        new()
        {
            Id = 200,
            ERPCode = 200,
            SortIndex = 200,
            Name = nameof(F_WorkItem),
            DisplayName = new StringBuilder().Append("تمام تاییدها")
                .Append($"({TableType.Facts})").ToString(),
            Display = false
        };

    public static readonly D_Entity F_Attachment =
        new()
        {
            Id = 202,
            ERPCode = 202,
            SortIndex = 202,
            Name = nameof(F_Attachment),
            DisplayName = new StringBuilder().Append("ضمیمه‌ها")
                        .Append($"({TableType.Facts})").ToString(),
            Display = false
        };

    public static readonly D_Entity F_Task =
        new()
        {
            Id = 203,
            ERPCode = 203,
            SortIndex = 203,
            Name = nameof(F_Task),
            DisplayName = new StringBuilder().Append("لیست تخصیص‌ها")
                        .Append($"({TableType.Facts})").ToString(),
            Display = false
        };

    public static readonly D_Entity F_Condition =
        new()
        {
            Id = 204,
            ERPCode = 204,
            SortIndex = 204,
            Name = nameof(F_Condition),
            DisplayName = new StringBuilder().Append("لیست شرط‌ها")
                .Append($"({TableType.Facts})").ToString(),
            Display = false
        };

    public static readonly D_Entity F_Case =
        new()
        {
            Id = 205,
            ERPCode = 205,
            SortIndex = 205,
            Name = nameof(F_Case),
            DisplayName = new StringBuilder().Append("اطلاعات درخواست‌ها")
                .Append($"({TableType.Facts})").ToString(),
            Display = false
        };

    public static readonly D_Entity F_Scenario =
        new()
        {
            Id = 206,
            ERPCode = 206,
            SortIndex = 206,
            Name = nameof(F_Scenario),
            DisplayName = new StringBuilder().Append("سناریوها")
                 .Append($"({TableType.Facts})").ToString(),
            Display = true
        };

    public static readonly D_Entity L_RolePosition =
        new()
        {
            Id = 300,
            ERPCode = 300,
            SortIndex = 300,
            Name = nameof(L_RolePosition),
            DisplayName = new StringBuilder().Append("نقش-سمت")
                        .Append($"({TableType.Links})").ToString(),
            Display = false
        };

    public static readonly D_Entity L_ProcessScenario =
        new()
        {
            Id = 301,
            ERPCode = 301,
            SortIndex = 301,
            Name = nameof(L_ProcessScenario),
            DisplayName = new StringBuilder().Append("فرآیند-سناریو")
                        .Append($"({TableType.Links})").ToString(),
            Display = false
        };

    public static readonly D_Entity L_UserLocation =
        new()
        {
            Id = 302,
            ERPCode = 302,
            SortIndex = 302,
            Name = nameof(L_UserLocation),
            DisplayName = new StringBuilder().Append("کاربر-موقعیت")
                        .Append($"({TableType.Links})").ToString(),
            Display = false
        };

    public static readonly D_Entity L_UserPosition =
        new()
        {
            Id = 303,
            ERPCode = 303,
            SortIndex = 303,
            Name = nameof(L_UserPosition),
            DisplayName = new StringBuilder().Append("کاربر-سمت")
                        .Append($"({TableType.Links})").ToString(),
            Display = false
        };

    #endregion
}